using System;
using System.Collections.Generic;
using System.Text;

namespace finallLib
{

        public class SatilikEv : Ev
        {
            public double SatisFiyat { get; set; }
            public SatilikEv() { }
            public SatilikEv(int odasayisi, string semt, double alan, int katno, double satisfiyat) : base(odasayisi, katno, semt, alan)
            {
                this.SatisFiyat = satisfiyat;
            }

            public override string EvBilgileri()
            {
                return $"{base.EvBilgileri()}\n Satış Fiyatı:{this.SatisFiyat}";
            }
        }

    
}
