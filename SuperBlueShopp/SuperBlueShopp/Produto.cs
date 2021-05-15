using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBlueShopp
{
    class Produto
    {
        public string nome { get; private set; }
        private double _preco;
        public double preco
        {
            get => _preco;
            set => _preco = value > 0 ? value : 0;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
