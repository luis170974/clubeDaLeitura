using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{
    public class Emprestimo
    {


        public Emprestimo[] registroEmprestimo = new Emprestimo[10];

        public DateTime strDataEmprestimo;
        public DateTime strDataDevolucao;
        public int contadorEmprestimos = 0;
        public Revista revistaEmprestimo;
        public Amigo amigosEmprestimo;





        public void CadastroEmprestimo()
        {
            registroEmprestimo[contadorEmprestimos] = new Emprestimo();

            

            Console.WriteLine("Id do amigo que efetuou o emprestimo da revista: ");
            amigosEmprestimo.MostraAmigosCadastrados();
            int pegaIdNome = int.Parse(Console.ReadLine());

            if(amigosEmprestimo.registroAmigo[pegaIdNome].possuiMulta == false)
            {
                if(amigosEmprestimo.registroAmigo[pegaIdNome].possuiEmprestimo == false)
                {
                    registroEmprestimo[contadorEmprestimos].amigosEmprestimo = amigosEmprestimo.registroAmigo[pegaIdNome];
                }
            }
            else
            {
                Console.WriteLine("Sem amigos registrados!");
            }


            Console.WriteLine("Qual a revista emprestada: ");
            revistaEmprestimo.MostraRevistasCadastradas();
            int idRevistaEmprestada = int.Parse(Console.ReadLine());

            if (revistaEmprestimo.contadorRevista > 0)
            {
                registroEmprestimo[contadorEmprestimos].revistaEmprestimo = revistaEmprestimo.registroRevistas[idRevistaEmprestada];
            }
            else
            {
                Console.WriteLine("Sem revistas registradas!");
            }

            Console.WriteLine("Data do emprestimo");
            DateTime dataEmprestimo = Convert.ToDateTime(Console.ReadLine());
            registroEmprestimo[contadorEmprestimos].strDataEmprestimo = dataEmprestimo;


            Console.WriteLine("Data de devolução");
            DateTime dataDevolucao = Convert.ToDateTime(Console.ReadLine());
            registroEmprestimo[contadorEmprestimos].strDataDevolucao = dataDevolucao;

            contadorEmprestimos++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Emprestimo cadastrado com sucesso");
            Console.ResetColor();
            Console.Clear();    

            


        }

        public void MostraEmprestimos()
        {
            if (contadorEmprestimos == 0)
            {
                Console.WriteLine("nao existem emprestimos");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            
                for (int i = 0; i < contadorEmprestimos; i++)
                {

                    Console.WriteLine("Id do emprestimo : " + i);

                    Console.WriteLine("Nome do amigo do Emprestimo : " + registroEmprestimo[i].amigosEmprestimo.nomeAmigo);

                    Console.WriteLine("Revista emprestada : " + registroEmprestimo[i].revistaEmprestimo.nomeColecaoRevista);

                    Console.WriteLine("Data de emprestimo : " + registroEmprestimo[i].strDataEmprestimo.ToString("dd/mm/yyyy"));

                    Console.WriteLine("Data de devolução : " + registroEmprestimo[i].strDataDevolucao.ToString("dd/mm/yyyy"));



                    break;
                }

            Console.ReadLine();
            Console.Clear();

        }
        }


    }


    

