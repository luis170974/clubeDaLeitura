using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{
    public class Menu
    {


        Amigo amigo = new Amigo();
        Caixa caixa = new Caixa();
        Emprestimo emprestimo = new Emprestimo();
        Revista revista = new Revista();
        Categoria categoria = new Categoria();
        Reservas reservas = new Reservas();
        
        
        
        


        public bool tenteNovamente = false;
        public string opcao = "0";





        public void MostraMenu()
        {


            Console.WriteLine("------MENU CLUBE DA LEITURA------");
            Console.WriteLine("1. Cadastrar amigo");
            Console.WriteLine("2. Mostrar amigos cadastrados");
            Console.WriteLine("3. Cadastrar caixa");
            Console.WriteLine("4. Mostrar caixas cadastradas");
            Console.WriteLine("5. Cadastrar revista");
            Console.WriteLine("6. Mostrar revistas cadastradas");
            Console.WriteLine("7. Cadastrar emprestimo");
            Console.WriteLine("8. Mostrar emprestimos cadsatrados");
            Console.WriteLine("0. Sair");



            Console.WriteLine("\nDigite uma opção!");
            opcao = Console.ReadLine();

         


                if (opcao == "1")
                {

                    amigo.CadastraAmigo();

                }


                else if (opcao == "2")
                {

                    amigo.MostraAmigosCadastrados();

                }

                else if (opcao == "3")
                {
                    caixa.CadastrarCaixa();

                }





                else if (opcao == "4")
                {
                    caixa.MostraCaixa();

                }


                else if (opcao == "5")
                {

                    revista.CadastrarRevista();

                }


                else if (opcao == "6")
                {
                    revista.MostraRevistasCadastradas();

                }

                else if (opcao == "7")
                {
                    emprestimo.CadastroEmprestimo();



                }

                else if (opcao == "8")
                {

                    emprestimo.MostraEmprestimos();

                }

                else if (opcao == "9")
                {
                    reservas.CadastrarReserva();
                }

                else if (opcao == "10")
                {
                    reservas.MostrarReservas();
                }


                else if (opcao == "0")
                {

                    Console.WriteLine("Finalizando o programa");
                    Environment.Exit(0);
                }

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "7" && opcao != "8" && opcao != "0")
                {
                    Console.WriteLine("Opção invalida!");
                    tenteNovamente = true;
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
            }
        }
    }

