using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace KelimeEzberlemeUygulamasi
{
    public static class SozlukYukleyici
    {
        public static List<Kelime> Yukle(string dosyaYolu)
        {
            List<Kelime> kelimeler = new List<Kelime>();
            foreach (string satir in File.ReadAllLines(dosyaYolu))
            {
                string[] parcalar = satir.Split('\t');
                if (parcalar.Length == 2)
                {
                    kelimeler.Add(new Kelime(parcalar[0].Trim(), parcalar[1].Trim()));
                }
            }
            return kelimeler;
        }
    }
}
