using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{
    public class Categoria
    {
        public Categoria[] registroCategorias = new Categoria[10];

        public string nomeCategoria;
        public int quantidadeDiasEmprestimo;
        public int contadorCategoria = 0;

        public void CadastroCategoria()
        {
            registroCategorias[contadorCategoria] = new Categoria();

            Console.WriteLine("Digite o nome da categoria : ");
            string pegaNomeCategoria = Console.ReadLine();
            registroCategorias[contadorCategoria].nomeCategoria = pegaNomeCategoria;

            Console.WriteLine("Digite a quantidade de dias do Emprestimo");
            int pegaQuantidadeDiasEmprestimo = int.Parse(Console.ReadLine());
            registroCategorias[contadorCategoria].quantidadeDiasEmprestimo = pegaQuantidadeDiasEmprestimo;

            
            contadorCategoria++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Categoria cadastrada com sucesso");
            Console.ResetColor();
            Console.Clear();

        }

        public void MostrarCategorias()
        {
            if (contadorCategoria == 0)
            {
                Console.WriteLine("Registro de categorias vazio!");
                Console.ReadLine();
                Console.Clear();
                return;

            }

            for (int i = 0; i < contadorCategoria; i++)
            {

                    Console.WriteLine("Id categoria : " + i);

                    Console.WriteLine("Nome da categoria : " + registroCategorias[i].nomeCategoria);

                    break;
                }

            Console.ReadLine();
            Console.Clear();
        }
        }
    }

