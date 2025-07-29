using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    class Program {
        static List<Livro> livros = new List<Livro>();
        static void Main(string[] args) {
            ExibirOpcoesDoMenu();
        }
            static void ExibirOpcoesDoMenu() {
                Console.WriteLine("___ MENU PRINCIPAL ___");
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Alterar");
                Console.WriteLine("3- Exibir");
                Console.WriteLine("4- Excluir");
                Console.WriteLine("5- Sair");
                Console.Write("Digite sua opção: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao) {
                    case 1:
                        CadastrarLivro();
                        break;
                    case 2:
                        AlterarLivro();
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
            }

            static void CadastrarLivro() {
                Console.Clear();
                Console.WriteLine("CADASTRAR LIVRO\n");
                /*
                Console.WriteLine("Código: ");
                int codigo = int.Parse(Console.ReadLine()!);
                
                Console.WriteLine("Autor: ");
                string autor = Console.ReadLine()!;
                */
                Console.Write("Título: ");
                string titulo = Console.ReadLine()!;

                // Console.WriteLine("Número de páginas: ");
                // int paginas = int.Parse(Console.ReadLine()!);

                Livro novoLivro = new Livro() {
                    //Codigo = codigo,
                    // Autor = autor,
                    Titulo = titulo
                    // Paginas = paginas
                };

                livros.Add(novoLivro);
                Console.WriteLine("Livro cadastrado com sucesso!");
                Thread.Sleep(1000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            static void AlterarLivro() {
                Console.Clear();
                Console.WriteLine("ALTERAR LIVRO \n");
                Console.Write("Digite o código do livro que deseja alterar: ");
                string titulo = Console.ReadLine()!;

                Livro livroParaAlterar = livros.Find(l => l.Titulo == titulo)!;

                if (livroParaAlterar != null) {
                    Console.WriteLine("Livro encontrado!");
                    Console.Write("Digite o novo título:");
                    string novoTitulo = Console.ReadLine()!;
                    livroParaAlterar.Titulo = novoTitulo;
                    Console.WriteLine("Livro alterado com sucesso!");
                } else {
                    Console.WriteLine($"O livro {titulo} não foi encontrado!");
                }
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            static void ExibirLivros() {
                Console.Clear();
                Console.WriteLine("EXIBIR LIVROS\n");
                foreach (Livro livro in livros) {
                    Console.WriteLine($"Título: {livro.Titulo}");
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }    
    }