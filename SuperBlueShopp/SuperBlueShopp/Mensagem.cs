using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBlueShopp
{
    class Mensagem
    {
        public string texto { get; set; }

        public Mensagem(string msg)
        {
            texto = $"{DateTime.Now.ToString()} - {msg}";
        }
    }
}
