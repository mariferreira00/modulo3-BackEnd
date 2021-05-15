using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBlueShopp
{
    class Estoque
    {
        List<Produto> produtos = new();
        List<Mensagem> mensagens = new();

        public void Cadastro()
        {
            Mensagem msg;
            Console.WriteLine("Informe um nome para o novo produto:");
            string nome = Console.ReadLine();

            var produto_existente = produtos.Find(p => p.nome == nome);
            if (produto_existente != null)
            {
                msg = new Mensagem($"O produto {nome} já existe!!!");
            }
            else
            {
                Console.WriteLine($"Informe um preço para o produto {nome}:");
                double preco = Convert.ToDouble(Console.ReadLine());
                Produto produto = new Produto(nome, preco);
                produtos.Add(produto);

                msg = new Mensagem($"O produto {nome} foi cadastrado com sucesso!");
            }

            Console.WriteLine(msg.texto);
            mensagens.Add(msg);
        }

        public void Listar()
        {
            Console.WriteLine("Os produtos cadastrados são:");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"{produto.nome} - R${produto.preco}");
            }

            Console.WriteLine($"O preço total do estoque é : {produtos.Sum(p => p.preco)}");
        }

        public void Excluir()
        {
            Mensagem msg;
            Console.WriteLine("Informe o nome do produto a ser excluido:");
            string nome = Console.ReadLine(); 
            Produto produto = produtos.Find(p => p.nome == nome);
            if (produto == null)
            {
                msg = new Mensagem($"O produto {nome} não existe!!!");
            }
            else
            {
                produtos.Remove(produto);
                msg = new Mensagem($"O produto {nome} foi removido");
            }

            Console.WriteLine(msg.texto);
            mensagens.Add(msg);
        }


        public void apresentarLogs()
        {
            Console.WriteLine("Os logs são");
            foreach (Mensagem m in mensagens)
            {
                Console.WriteLine(m.texto);
            }
        }

        public void Alteracaopreco()
        {
            Mensagem msg;
            Console.WriteLine("Informe o nome do produto a ser alterado: ");

            string nome = Console.ReadLine();

            Produto produto = produtos.Find(prod => prod.nome == nome);

            if (produto == null)
            {
                msg = new Mensagem($"Esse produto { nome } não existe: ");
            }
            else
            {
                Console.WriteLine("indique o novo valor a ser alterado: ");
                int novoPreco = Convert.ToInt32(Console.ReadLine());
                produto.preco = novoPreco;
                msg = new Mensagem($"O produto { nome } foi alterado com sucesso! ");
            }
            mensagens.Add(msg);

        }
    }
}
