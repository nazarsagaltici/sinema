using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinema
{
    public abstract class kişi
    {
        public string ad
        {
            get
            {
                return ad;
            }
            set
            {
                value = ad;
            }
        }
        public string soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                value = soyad;
            }


        }
        
        
            public virtual double Hesap()
            {
                const double s1 = 60;
            double fiyat = s1 - 10;
                return fiyat;

            }
            public abstract double Hesap2();
            
                

            
        
    }
}