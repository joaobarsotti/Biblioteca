using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    class Program {
        static List<Livro> livros = new List<Livro>();
        static void Main(string[] args) {
            int opcao;

            do {
                Console.WriteLine("___ MENU PRINCIPAL ___");
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Alterar");
                Console.WriteLine("3- Exibir");
                Console.WriteLine("4- Excluir");
                Console.WriteLine("5- Sair");
                Console.Write("Digite sua opção: ");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao) {
                    case 1:
                        CadastrarLivro();
                        break;
                    case 2:
                        Console.WriteLine("ALTERAR");
                        break;
                    case 3:
                        ExibirLivros();
                        break;
                    case 4:
                        Console.WriteLine("EXCLUIR");
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 5);
        }

        static void CadastrarLivro() {
            Console.Clear();
            Console.WriteLine("CADASTRAR LIVRO\n");

            /*Console.WriteLine("Código: ");
            int codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine()!;
            */
            Console.WriteLine("Título: ");
            string titulo = Console.ReadLine()!;

           // Console.WriteLine("Número de páginas: ");
           // int paginas = int.Parse(Console.ReadLine()!);

            Livro novoLivro = new Livro() {
               // Codigo = codigo,
               // Autor = autor,
                Titulo = titulo
                // Paginas = paginas
            };

            livros.Add(novoLivro);
            Console.WriteLine("Livro cadastrado com sucesso!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void ExibirLivros() {
            Console.Clear();
            Console.WriteLine("EXIBIR LIVROS\n");
            //for(int i = 0; i < livros.Count; i++) {
              //  Console.WriteLine($"Título: {livros[i].Titulo}");
            //}
            foreach (Livro livro in livros) {
                Console.WriteLine($"Título: {livro.Titulo}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
