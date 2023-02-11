using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Model
{
    public class EncryptedProfile
    {
        public string name { get; set; }
        public string baseImg64 { get; set; }

        public byte[] profileEncrypted { get; set; }
    }
}
