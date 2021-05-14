using System;
using System.Globalization;

namespace codelabsAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = ObterOpcaoUsuario();
            int qtdAlunos = 0;
            string[] listaAlunos = new string[qtdAlunos];
            double[] nota1Alunos = new double[qtdAlunos];
            double[] nota2Alunos = new double[qtdAlunos];
            double[] mediaAlunos = new double[qtdAlunos];
            int[] faltaAlunos = new int[qtdAlunos];
            while (opcaoUsuario != 0)
            {

                switch (opcaoUsuario)
                {
                    case 1:
                        CadastrarTurma();
                        break;
                        

                    case 2:
                        CadastrarAlunos();
                        break;
                       

                    case 3:
                        ListarAlunos();
                        break;
                        

                    case 4:
                        AdicionarNotas();
                        break;
                        

                    case 5:
                        AdicionarFalta();
                        break;

                }
                opcaoUsuario = ObterOpcaoUsuario();

            }

            void CadastrarTurma(){
                Console.WriteLine("Informe o nome da turma a ser cadastrada: ");
                string nome_sala = Console.ReadLine().ToUpper();
                Console.WriteLine("Informe a quantidade de alunos dessa turma: ");
                qtdAlunos = int.Parse(Console.ReadLine());
                Console.WriteLine($"A turma {nome_sala}, com máximo de {qtdAlunos} alunos, foi criada com sucesso!");
                listaAlunos = new string[qtdAlunos];
                nota1Alunos = new double[qtdAlunos];
                nota2Alunos = new double[qtdAlunos];
                mediaAlunos = new double[qtdAlunos];
                faltaAlunos = new int[qtdAlunos];

            }

            void CadastrarAlunos()
            {
                Console.WriteLine("Informe o nome do aluno a ser cadastrado: ");
               
                for(int x = 0; x < listaAlunos.Length; x++)
                {
                    
                    Console.WriteLine($"Aluno {x + 1}");
                    listaAlunos[x] = Console.ReadLine().ToUpper();                   
                }
            }

            void ListarAlunos()
            {
               
                for(int x = 0; x < listaAlunos.Length; x++)
                {
                    Console.WriteLine($"Aluno {x} : {listaAlunos[x]} | Nota 1 : {nota1Alunos[x].ToString("F2", CultureInfo.InvariantCulture)} | Nota 2 : {nota2Alunos[x].ToString("F2", CultureInfo.InvariantCulture)} | Média : {mediaAlunos[x].ToString("F2", CultureInfo.InvariantCulture)} | Faltas: {faltaAlunos[x]} |");
                    if(mediaAlunos[x] < 7 || faltaAlunos[x] >= 4)
                    {
                        Console.WriteLine("Reprovado conforme política de notas e faltas");
                    }
                    else
                    {
                        Console.WriteLine("Aprovado! ");
                    }
                }
            }

            void AdicionarNotas()
            {
                Console.WriteLine("Informe nome do aluno para o qual deseja atribuir nota: ");
                string nomeAluno = Console.ReadLine().ToUpper();
                for (int x = 0; x < listaAlunos.Length; x++)
                {
                    if(listaAlunos[x] == nomeAluno)
                    {
                        Console.WriteLine($"Informe a primeira nota a ser atribuida ao aluno {listaAlunos[x]} (de 0 a 10 para numeros decimais utilize ' . '): ");
                        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine($"Informe a segunda nota a ser atribuida ao aluno {listaAlunos[x]} (de 0 a 10 para numeros decimais utilize ' . '): ");                        
                        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        double media = (nota1 + nota2) / 2;
                        if(nota1 > 0 && nota1 <= 10 || nota2 > 0 && nota2 <= 10)
                        {
                            nota1Alunos[x] = nota1;
                            nota2Alunos[x] = nota2;
                            mediaAlunos[x] = media;
                            Console.WriteLine($"Aluno(a) {listaAlunos[x]} - notas {nota1Alunos[x].ToString("F2", CultureInfo.InvariantCulture)} e {nota2Alunos[x].ToString("F2", CultureInfo.InvariantCulture)} cadastradas com sucesso! média :  {mediaAlunos[x].ToString("F2", CultureInfo.InvariantCulture)} ");
                        }
                        else
                        {
                            Console.WriteLine("Você informou uma nota inválida, por favor, digite novamente uma nota de 0 a 10: ");
                        }
                    }
                }
            }

            void AdicionarFalta()
            {
                Console.WriteLine("Informe o nome do aluno para o qual deseja atribuir falta: ");
                string nomeAluno = Console.ReadLine().ToUpper();
                for (int x = 0; x < listaAlunos.Length; x++)
                {
                    if(listaAlunos[x] == nomeAluno)
                    {
                        faltaAlunos[x]++;
                        Console.WriteLine($"O Aluno {listaAlunos[x]} encontra-se com {faltaAlunos[x]} faltas até o momento. ");

                    }                    
                }
            }

            int ObterOpcaoUsuario()
            {
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("1 - Cadastrar nova turma ");
                Console.WriteLine("2 - Cadastrar aluno ");
                Console.WriteLine("3 - Listar Alunos cadastrados ");
                Console.WriteLine("4 - Atribuir notas ");
                Console.WriteLine("5 - Atribuir falta a um aluno cadastrado ");
                Console.WriteLine("0 - Sair ");
                int opcaoUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine();
                return opcaoUsuario;

            }
 
        }
    }
}
