using System;
using System.Collections.Generic;
using System.Text;

namespace finallLib
{
    
        public class KiralikEv : Ev
        {
            public int Kira { get; set; }
            public int Depozito { get; set; }
            public KiralikEv() { }

            public KiralikEv(int odasayisi, string semt, double alan, int katno, int kira, int depozito) : base(odasayisi, katno, semt, alan)
            {
                this.Kira = kira;
                this.Depozito = depozito;
            }

            public override string EvBilgileri()
            {
                return $"{base.EvBilgileri()}\n Kira Fiyatı:{this.Kira}\n Depozito:{this.Depozito}";
            }
        }

    
}
