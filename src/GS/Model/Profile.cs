using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Model
{
    public class Profile
    {
        public string FullFileName { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; private set; }
        public string Senha { get; set; }
        public DateTime DtCreated { get; private set; }
        public List<SecretBox> Boxes { get; set; }
        public bool SecretKey { get; private set; }
        public string ImageBase64 { get; set; }


        public Profile(string fullFileName,
            string nome,
            DateTime dataNascimento,
            bool secretKey,
            string senha,
            DateTime dtCreated,
            List<SecretBox> lssecrets,
            string imageBase64
            )
        {

            this.FullFileName = fullFileName;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Senha = senha;
            this.DtCreated = dtCreated;
            this.Boxes = lssecrets;
            this.SecretKey = secretKey;
            this.ImageBase64 = imageBase64;


        }


    }
}
