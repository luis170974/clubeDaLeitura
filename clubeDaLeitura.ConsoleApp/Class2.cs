using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp

{
    public class Caixa
    {

        public Caixa[] registroCaixa = new Caixa[10];


        public string strCorCaixaGuardada;
        public string strEtiquetaCaixa;
        public string strNumeroCaixa;
        public int contadorCaixa = 0;
        public int contadorRevistaNaCaixa = 0;
        Revista[] revistasNaCaixa = new Revista[10]; 


        public void CadastrarCaixa()
        {
            registroCaixa[contadorCaixa] = new Caixa();


            Console.WriteLine("Cor da caixa ");
            string corDaCaixa = Console.ReadLine();
            registroCaixa[contadorCaixa].strCorCaixaGuardada = corDaCaixa;

            Console.WriteLine("Etiqueta da caixa: ");
            string etiquetaDaCaixa = Console.ReadLine();
            registroCaixa[contadorCaixa].strEtiquetaCaixa = etiquetaDaCaixa;

            Console.WriteLine("Numero da caixa: ");
            string numeroDaCaixa = Console.ReadLine();
            registroCaixa[contadorCaixa].strNumeroCaixa = numeroDaCaixa;
            
            contadorCaixa++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Caixa cadastrada com sucesso");
            Console.ResetColor();
            Console.Clear();
            // cada caixa tem cor, uma etiqueta e um número.
            
            


        }

        public void ColocarRevistaCaixa(Revista registroRevista)
        {
            revistasNaCaixa[contadorRevistaNaCaixa] = registroRevista;
            contadorRevistaNaCaixa++;
        }

        public void MostrarRevistasNaCaixa()
        {
            if (contadorRevistaNaCaixa == 0)
            {
                Console.WriteLine("Nao existem revistas na caixa");
                Console.ReadLine();
                Console.Clear();
                return;

            }

            for (int i = 0; i < contadorRevistaNaCaixa; i++)
            {

                Console.WriteLine("Id : " + i);

                Console.WriteLine("Revista na caixa: " + revistasNaCaixa[i].nomeColecaoRevista);



                break;
            }

            Console.ReadLine();
            Console.Clear();
        }

        public void MostraCaixa()
        {
            if (contadorCaixa == 0)
            {
                Console.WriteLine("Nao existem caixas");
                Console.ReadLine();
                Console.Clear();
                return;

            }

            for (int i = 0; i < contadorCaixa; i++)
            {

                    Console.WriteLine("Id : " + i);

                    Console.WriteLine("Cor da caixa: " + registroCaixa[i].strCorCaixaGuardada);

                    Console.WriteLine("Etiqueta da caixa : " + registroCaixa[i].strEtiquetaCaixa);

                    Console.WriteLine("Numero da caixa : " + registroCaixa[i].strNumeroCaixa);


                    break;
             }

            Console.ReadLine();
            Console.Clear();

        }

        }







    }


