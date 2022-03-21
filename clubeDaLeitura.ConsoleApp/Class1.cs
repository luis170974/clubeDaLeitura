using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{

    public class Revista {



        public Revista[] registroRevistas = new Revista[10];

        public string nomeColecaoRevista;
       
        public string numeroDaEdicao;
        
        public string anoRevista;

        public int contadorRevista = 0;

        public Caixa caixa;

        public Categoria categoria;


        public void CadastrarRevista()
        {

            registroRevistas[contadorRevista] = new Revista();



            Console.WriteLine("Digite a coleção da revista: ");
            string colecaoRevista = Console.ReadLine();
            registroRevistas[contadorRevista].nomeColecaoRevista = colecaoRevista;


            Console.WriteLine("Digite o numero da edição: ");
            int numeroDaEdicao = int.Parse(Console.ReadLine());
            registroRevistas[contadorRevista].numeroDaEdicao = numeroDaEdicao.ToString();

            Console.WriteLine("Digite o ano da revista: ");
            int anoRevista = int.Parse(Console.ReadLine());
            registroRevistas[contadorRevista].anoRevista = anoRevista.ToString();
            
            
            caixa.MostraCaixa();

            Console.WriteLine("Em qual caixa esta guardada");
            
            int idCaixaQueFoiEscolhido = int.Parse(Console.ReadLine());
            registroRevistas[contadorRevista].caixa = caixa.registroCaixa[idCaixaQueFoiEscolhido];


            Console.WriteLine("Em qual categoria essa revista esta? : ");
            categoria.MostrarCategorias();
            int idCategoriaEscolhida = int.Parse(Console.ReadLine());
            registroRevistas[contadorRevista].categoria = categoria.registroCategorias[idCategoriaEscolhida];

            contadorRevista++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista cadastrada com sucesso");
            Console.ResetColor();
            Console.Clear();


            // cada caixa tem cor, uma etiqueta e um número.



            




        }

        public void MostraRevistasCadastradas()
        {
            if (contadorRevista == 0)
            {
                Console.WriteLine("Registro Vazio!");
                Console.ReadLine();
                Console.Clear();
                return;

            }
            for (int i = 0; i < contadorRevista; i++)
            {



                    Console.WriteLine("Id da revista : " + i);

                    Console.WriteLine("coleção da revista : " + registroRevistas[i].nomeColecaoRevista);

                    Console.WriteLine("numero da edição : " + registroRevistas[i].numeroDaEdicao);

                    Console.WriteLine("ano da revista : " + registroRevistas[i].anoRevista);

                    Console.WriteLine("cor da caixa esta guardada : " + registroRevistas[i].caixa);

                    Console.WriteLine("categoria da revista : " + registroRevistas[i].categoria);


                    break;
                


            }
            Console.ReadLine();
            Console.Clear();
        }








    }
}



    


