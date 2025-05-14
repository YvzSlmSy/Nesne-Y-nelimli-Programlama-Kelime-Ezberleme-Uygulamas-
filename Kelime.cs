using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberlemeUygulamasi
{
    public class Kelime
    {
        public string Ingilizce { get; set; }
        public string Turkce { get; set; }

        public Kelime(string ingilizce, string turkce)
        {
            Ingilizce = ingilizce;
            Turkce = turkce;
        }
    }

}
