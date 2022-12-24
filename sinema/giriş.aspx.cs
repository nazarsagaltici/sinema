using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sinema
{
    public partial class giriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            bilgi b = new bilgi();
            b.TcNo = TextBox3.Text;
            

            if (TextBox3.Text.Length == 11)
            {
                if (DropDownList1.SelectedValue == "SALON 1")
                {
                    Response.Redirect("salon1.aspx");
                }
                else 
                {
                    Response.Redirect("salon2.aspx");
                }
            }
            else { Label5.Text = b.uyarı; }
            
            
        }
    }
}