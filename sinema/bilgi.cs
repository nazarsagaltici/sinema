using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinema
{
    public class bilgi:kişi,Ibilgiler
    {
        public string uyarı { get; set; }
        public string seç { get; set; }

    private string Tc;
        public string TcNo
        {
            get
            {
                return Tc;
            }
            set
            {
                if (value.Length<11 || value.Length>11)
                {

                    uyarı= "hatalı giriş yaptınız";
                    
                }
                else
                {
                    Tc = value;
                }
            }
        }

        public double  dyılı
        {
            get
            {
                return dyılı;
            }
            set
            {
                value = dyılı;
            }
        }

            public double telno
        {
            get
            {
                return telno;
            }
            set
            {
                value = telno;
            }
        }
       
        public override double Hesap2()
        {

            const double s2 = 30;
            double fiyat = s2 - 10;
            return fiyat;
        }




       





    }
   
    



}