using System;

namespace clubeDaLeitura.ConsoleApp
{

    public class Amigo
    {


        #region caracteristicas, atributos


        public Amigo[] registroAmigo = new Amigo[10];

        public string nomeAmigo;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;
        public bool possuiMulta;
        public bool possuiEmprestimo;
        public int contadorAmigo = 0;

        public void CadastraAmigo()
        {

            registroAmigo[contadorAmigo] = new Amigo();



            Console.WriteLine("Nome do amigo: ");
            string nomeAmigo = Console.ReadLine();
            registroAmigo[contadorAmigo].nomeAmigo = nomeAmigo;

            Console.WriteLine("Nome do Responsável: ");
            string nomeResponsavel = Console.ReadLine();
            registroAmigo[contadorAmigo].nomeResponsavel = nomeResponsavel;

            Console.WriteLine("Telefone");
            string telefoneCadastro = Console.ReadLine();
            registroAmigo[contadorAmigo].telefone = telefoneCadastro;

            if (registroAmigo[contadorAmigo].telefone.Length > 9)
            {
                Console.WriteLine("nao é possivel cadastrar um telefone com mais de 9 digitos");
                Console.ReadLine();
                Console.Clear();
                return;

            }


            Console.WriteLine("Endereço");
            string enderecoCadastro = Console.ReadLine();
            registroAmigo[contadorAmigo].endereco = enderecoCadastro;


            registroAmigo[contadorAmigo].possuiEmprestimo = false;

            registroAmigo[contadorAmigo].possuiMulta = false;

            contadorAmigo++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Amigo cadastrado com sucesso");
            Console.ResetColor();
            Console.Clear();



        }

        public void MostraAmigosCadastrados()
        {
            if (contadorAmigo == 0)
            {
                Console.WriteLine("nao existem amigos!");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            for (int i = 0; i < contadorAmigo; i++)
            { 
                    Console.WriteLine("Id amigo : " + i);

                    Console.WriteLine("Nome do amigo : " + registroAmigo[i].nomeAmigo);

                    Console.WriteLine("Nome do Responsável : " + registroAmigo[i].nomeResponsavel);

                    Console.WriteLine("Telefone : " + registroAmigo[i].telefone);

                    Console.WriteLine("Endereço : " + registroAmigo[i].endereco);



                    break;
                
                
            }

            Console.ReadLine();
            Console.Clear();

        }
        #endregion















    }
}
 


       








/*
Para cada Revista, deverá ser cadastrado:
• o tipo de coleção
• o número da edição
• o ano da revista
• a caixa onde está guardada

Cada caixa tem uma cor, uma etiqueta e um número.
Para cada Empréstimo cadastram-se:

• o amigo que pegou a revista
• qual foi a revista emprestada
• a data do empréstimo
• a data de devolução

Cada criança só pode pegar uma revista por empréstimo.
O cadastro do Amigo consiste de:
• nome
• nome do responsável
• telefone
• endereço

Mensalmente Gustavo verifica os empréstimos realizados no mês e diariamente os
empréstimos que estão em aberto.
*/