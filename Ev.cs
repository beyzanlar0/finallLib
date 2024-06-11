using System;

namespace finallLib
{
    public class Ev
    {
       
            private static int sayac = 0;
            public Ev()
            {
            sayac++;

            }

        public Ev(int odasayisi, int katno, string semt, double alan)
            {
                this.Odasayisi = odasayisi;
                this.Katno = katno;
                this.Semt = semt;
                this.Alan = alan;
                sayac++;


        }
        public Ev(int odasayisi, int katno, double alan)
            {
                this.Odasayisi = odasayisi;
                this.Katno = katno;
                this.Semt = "Gazi";
                this.Alan = alan;
                sayac++;

        }

        private int odasayisi;
            private int katno;
            private string semt;
            private double alan;

            public int Odasayisi { get => odasayisi; set => odasayisi = value; }
            public int Katno { get => katno; set => katno = value; }
            public string Semt { get => semt; set => semt = value.ToUpper(); }
            public static int Sayac { get => sayac; }
             public double Alan { get => alan; set => alan = value; }

            public virtual string EvBilgileri()
            {
                return $"Oda sayısı: {this.Odasayisi}\n Kat No:{this.Katno}\n Alan:{this.Alan}\n Semt:{this.Semt}";
            }
        }

    
}
