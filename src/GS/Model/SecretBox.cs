using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Model
{
    public class SecretBox
    {
        public bool Favorito { get; set; }
        public System.Windows.Media.Color NewBaseColor { get; set; }
        public string BoxName { get; set; }
        public string Url { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Obs { get; set; }
        public string Base64IMG { get; set; }
        public DateTime DtCreated { get; set; }
    }
}
