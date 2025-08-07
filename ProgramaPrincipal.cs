using System;
using System.Collections.Generic;
using System.Globalization;
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
                    ExcluirLivro();
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
   
            Console.Write("Título: ");
            string titulo = Console.ReadLine()!;

            Console.Write("Autor: ");
            string autor = Console.ReadLine()!;

            Console.Write("Categoria: ");
            string categoria = Console.ReadLine()!;

            Console.Write("Número de páginas: ");
            int paginas = int.Parse(Console.ReadLine()!);

            Console.Write("Status: ");
            string status = Console.ReadLine()!;

            Livro novoLivro = new Livro() {
                Titulo = titulo,
                Autor = autor,
                Categoria = categoria,
                Paginas = paginas,
                Status = status
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
            Console.Write("Digite o título do livro que deseja alterar: ");
            string titulo = Console.ReadLine()!;

            Livro livroParaAlterar = livros.Find(l => l.Titulo == titulo)!;

            if (livroParaAlterar != null) {
                Console.WriteLine("Livro encontrado! Informe os novos dados ou pressione enter para manter o valor atual:");

                Console.WriteLine($"Título atual: {livroParaAlterar.Titulo}");
                Console.Write("Novo título: ");
                string novoTitulo = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(novoTitulo)) {
                    livroParaAlterar.Titulo = novoTitulo;
                }

                Console.WriteLine($"Autor atual: {livroParaAlterar.Autor}");
                Console.Write("Novo autor: ");
                string novoAutor = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(novoAutor)) {
                    livroParaAlterar.Autor = novoAutor;
                }
                
                Console.WriteLine($"Categoria atual: {livroParaAlterar.Categoria}");
                Console.Write("Nova categoria: ");
                string novaCategoria = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(novaCategoria)) {
                    livroParaAlterar.Categoria = novaCategoria;
                }

                Console.WriteLine($"Número de Páginas atual: {livroParaAlterar.Paginas}");
                Console.Write("Novo número de páginas: ");
                string novoPaginas = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(novoPaginas) && int.TryParse(novoPaginas, out int paginas)) {
                    livroParaAlterar.Paginas = paginas;
                }

                Console.WriteLine($"Status atual: {livroParaAlterar.Status}");
                Console.Write("Novo status: ");
                string novoStatus = Console.ReadLine()!;
                if (!string.IsNullOrWhiteSpace(novoStatus)) {
                    livroParaAlterar.Status = novoStatus;
                }

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
            if (livros.Count == 0) {
                Console.WriteLine("Nenhum livro cadastrado");
            } else {
                foreach (Livro livro in livros) {
                    Console.WriteLine($"Título: {livro.Titulo}");
                }
            }
                
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

        static void ExcluirLivro() {
            Console.Clear();
            Console.WriteLine("EXCLUIR LIVRO\n");
            Console.Write("Digite o código do livro que deseja excluir: ");
            string titulo = Console.ReadLine()!;

            Livro livroParaExcluir = livros.Find(l => l.Titulo == titulo)!;

            if (livroParaExcluir != null) {
                livros.Remove(livroParaExcluir);
                Console.WriteLine("Livro excluído com sucesso!");
            } else {
                Console.WriteLine($"O livro {titulo} não foi encontrado!");
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }    
}