using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBlueShopp
{
    class SuperBlueShop
    {
        Estoque estoque = new Estoque();
        public void Start()
        {
            Console.WriteLine("\nSelecione uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar um produto");
            Console.WriteLine("2 - Listar produtos cadastrados");
            Console.WriteLine("3 - Excluir um produto");
            Console.WriteLine("4 - Mostrar registro de logs");
            Console.WriteLine("5- Alterra o preço de um produto");
            Console.WriteLine("0 - sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastroDeProdutos();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "3":
                    excluirProduto();
                    break;
                case "4":
                    apresentarLogs();
                    break;
                case "5":
                    alterarPreco();
                    break;
                case "0":
                    Console.WriteLine("Finalizando aplicação");
                    return;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Start();
        }

        void CadastroDeProdutos()
        {
            estoque.Cadastro();
        }

        void ListarProdutos()
        {
            estoque.Listar();
        }

        void excluirProduto()
        {
            estoque.Excluir();
        }

        void apresentarLogs()
        {
            estoque.apresentarLogs();
        }

        void alterarPreco()
        {
            estoque.alteracaoPreco();
        }
    }
}
