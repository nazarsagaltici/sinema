using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sinema
{
    public partial class salon1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bilgi a = new bilgi();
            Label2.Text = "1 NUMARALI SALONU SEÇTİNİZ";
            if (CheckBox1.Checked == true)
            {
                CheckBox1.BackColor = System.Drawing.Color.Green;
                Label4.Text = CheckBox1.Text;
            }
            else CheckBox1.BackColor = System.Drawing.Color.Red;


            if (CheckBox2.Checked == true)
            {
                CheckBox2.BackColor = System.Drawing.Color.Green;
                Label4.Text = CheckBox2.Text;
            }
            else CheckBox2.BackColor = System.Drawing.Color.Red;


             if (CheckBox3.Checked == true)
            {
                CheckBox3.BackColor = System.Drawing.Color.Green;
                Label4.Text = CheckBox3.Text;

            }
            else CheckBox3.BackColor = System.Drawing.Color.Red;


             if (CheckBox4.Checked == true)
            {
                CheckBox4.BackColor = System.Drawing.Color.Green;
                Label4.Text = CheckBox4.Text;
            }
            else CheckBox4.BackColor = System.Drawing.Color.Red;


             if (CheckBox5.Checked == true)
            {
                CheckBox5.BackColor = System.Drawing.Color.Green;
                Label4.Text = CheckBox5.Text;
            }
            else CheckBox5.BackColor = System.Drawing.Color.Red;


            if (CheckBox6.Checked == true)
            {
                CheckBox6.BackColor = System.Drawing.Color.Green;
                Label4.Text = CheckBox6.Text;
            }
            else CheckBox6.BackColor = System.Drawing.Color.Red;


            


            if (CheckBox7.Checked == true) { Label6.Text = a.Hesap().ToString(); }
            else { Label6.Text = "60"; }
            
            

        }
    }
}