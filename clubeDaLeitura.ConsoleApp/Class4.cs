using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{
    public class Menu
    {
        public string opcao;

        public bool tenteNovamente = false;


        Caixa[] CaixaDeRevista = new Caixa[10];

        Revista[] revistas = new Revista[10];

        Emprestimo[] NovoEmprestimo = new Emprestimo[10];

        Amigo[] amigo = new Amigo[10];

        public void MostraMenuEValida()
        {
    
            Console.WriteLine("Menu clube da leitura");

            Console.WriteLine("1. Cadastrar revista");
            Console.WriteLine("2. Cadastrar emprestimo de revista");
            Console.WriteLine("3. Cadastrar amigo");
            Console.WriteLine("4. Historico de revistas registradas");
            Console.WriteLine("5. Historico de amigos registrados");
            Console.WriteLine("6. Cadastrar caixas");
            Console.WriteLine("7. Historico de emprestimos");
            Console.WriteLine("8. sair");


            opcao = Console.ReadLine();

            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "7" && opcao != "8")
            {
                Console.WriteLine("Opção Invalida!");
                Console.ReadLine();
                Console.Clear();
                tenteNovamente = true;
                return;
            }



        }

        public void ValidaOpcoes() {

            if (opcao == "1")
            {

                CadastrarRevista();

            }

            else if (opcao == "2")
            {

                CadastroEmprestimoRevista();

            }


            else if (opcao == "3")
            {

                CadastraAmigo();

            }

            else if (opcao == "4")
            {

                MostraRevistasCadastradas();

            }

            else if (opcao == "5")
            {

                MostraAmigosCadastrados();
            }


            else if (opcao == "6")
            {

                CadastrarCaixa();

            }

            else if (opcao == "7")
            {
                MostraEmprestimos();
            }

            if (opcao == "8")
            {
                Environment.Exit(0);
            }
        }

        public void CadastrarRevista()
        {


            Revista novaRevista = new Revista();



            Console.WriteLine("Digite a coleção da revista: ");
            string colecaoRevista = Console.ReadLine();
            novaRevista.strNomecolecaoRevista = colecaoRevista;


            Console.WriteLine("Digite o numero da edição: ");
            int numeroDaEdicao = int.Parse(Console.ReadLine());
            novaRevista.strNumeroDaEdicao = numeroDaEdicao.ToString();

            Console.WriteLine("Digite o ano da revista: ");
            int anoRevista = int.Parse(Console.ReadLine());
            novaRevista.strAnoRevista = anoRevista.ToString();

            Console.WriteLine("Em qual caixa esta guardada");
            
            //int caixaGuardada = int.Parse(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista cadastrada com sucesso");
            Console.ResetColor();


            // cada caixa tem cor, uma etiqueta e um número.




            for(int i = 0; i < revistas.Length; i++)
            {
                if(revistas[i] == null)
                {
                    revistas[i] = novaRevista;
                    break;
                }
            }
            Console.Clear();
        }

        public void CadastroEmprestimoRevista()
        {
            


                Emprestimo novoEmprestimo = new Emprestimo();

                Console.WriteLine("Id do amigo que efetuou o emprestimo da revista: ");

                MostraAmigosCadastrados();

                string pegaIdNome = Console.ReadLine();



                Console.WriteLine("Qual a revista emprestada: ");
                MostraRevistasCadastradas();
                string idRevistaEmprestada = Console.ReadLine();


                Console.WriteLine("Data do emprestimo");
                DateTime dataEmprestimo = Convert.ToDateTime(Console.ReadLine());
                novoEmprestimo.strDataEmprestimo = dataEmprestimo;


                Console.WriteLine("Data de devolução");
                DateTime dataDevolucao = Convert.ToDateTime(Console.ReadLine());
                novoEmprestimo.strDataDevolucao = dataDevolucao;


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Produto cadastrado com sucesso");
                Console.ResetColor();


            }
   

        public void CadastraAmigo()
        {

            Amigo novoAmigo = new Amigo();



                Console.WriteLine("Nome do amigo: ");
                string nomeAmigo = Console.ReadLine();
                novoAmigo.strNome = nomeAmigo;

                Console.WriteLine("Nome do Responsável: ");
                string nomeResponsavel = Console.ReadLine();
                novoAmigo.strNomeResponsavel = nomeResponsavel;

                Console.WriteLine("Telefone");
                string telefoneCadastro = Console.ReadLine();
                novoAmigo.strTelefone = telefoneCadastro;

                if (novoAmigo.strTelefone.Length > 9)
                {
                    Console.WriteLine("nao é possivel cadastrar um telefone com mais de 9 digitos");
                    Console.ReadLine();
                    Console.Clear();
                    return;

                }


                Console.WriteLine("Endereço");
                string enderecoCadastro = Console.ReadLine();
                novoAmigo.strEndereco = enderecoCadastro;

                for(int i = 0; i < amigo.Length; i++)
                {
                    if(amigo[i] == null)
                    {
                    amigo[i] = novoAmigo;
                    break;
                    }
                }

            Console.ReadLine();
            Console.Clear();

        }


        public void CadastrarCaixa()
        {
            Caixa novaCaixa = new Caixa();

                Console.WriteLine("Cor da caixa ");
                string corDaCaixa = Console.ReadLine();
                novaCaixa.strCorCaixaGuardada = corDaCaixa;

                Console.WriteLine("Etiqueta da caixa: ");
                string etiquetaDaCaixa = Console.ReadLine();
                novaCaixa.strEtiquetaCaixa = etiquetaDaCaixa;

                Console.WriteLine("Numero da caixa: ");
                string numeroDaCaixa = Console.ReadLine();
                novaCaixa.strNumeroCaixa = numeroDaCaixa;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Caixa cadastrada com sucesso");
                Console.ResetColor();
                // cada caixa tem cor, uma etiqueta e um número.
           
                Console.ReadLine();
                Console.Clear();

            for(int i = 0; i < CaixaDeRevista.Length; i++)
                {
                if(CaixaDeRevista[i] == null)
                {

                    CaixaDeRevista[i] = novaCaixa;
                    break;
                }
            }
        }


        public void MostraCaixa()
                {
                    

                    for (int i = 0; i < CaixaDeRevista.Length; i++)
                    {
                        int idCaixa = i;

                        if (CaixaDeRevista[i] != null)
                        {
                            Console.WriteLine("Id da caixa: " + idCaixa);

                            Console.WriteLine("Cor da caixa: " + CaixaDeRevista[i].strCorCaixaGuardada);

                            Console.WriteLine("Etiqueta da caixa : " + CaixaDeRevista[i].strEtiquetaCaixa);

                            Console.WriteLine("Numero da caixa : " + CaixaDeRevista[i].strNumeroCaixa);



                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        else 
                        {
                            Console.WriteLine("Nao existem caixas");
                            Console.ReadLine();
                            Console.Clear();
                            continue;

                        }

                    }
                    
                }
        

       public void MostraAmigosCadastrados()
        {
            

            for (int i = 0; i < amigo.Length; i++)

                if (amigo[i] != null)
                {
                    int idAmigo = i;

                    Console.WriteLine("Id " + idAmigo);

                    Console.WriteLine("Nome do amigo : " + amigo[i].strNome);

                    Console.WriteLine("Nome do Responsável : " + amigo[i].strNomeResponsavel);

                    Console.WriteLine("Telefone : " + amigo[i].strTelefone);

                    Console.WriteLine("Endereço : " + amigo[i].strEndereco);

                    Console.ReadLine();
                    Console.Clear();

                    break;
                }

                else
                {
                    Console.WriteLine("Registro Vazio!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
        }


        public void MostraEmprestimos()
        {
            for (int i = 0; i < NovoEmprestimo.Length; i++)
            {

                if (NovoEmprestimo[i] != null)
                {

                    Console.WriteLine("Nome do amigo do Emprestimo : " + amigo[i].strNome);

                    Console.WriteLine("Revista emprestada : " + revistas[i].strNomecolecaoRevista);

                    Console.WriteLine("Data de emprestimo : " + NovoEmprestimo[i].strDataEmprestimo.ToString("dd/mm/yyyy"));

                    Console.WriteLine("Data de devolução : " + NovoEmprestimo[i].strDataDevolucao.ToString("dd/mm/yyyy"));


                    Console.ReadLine();
                    Console.Clear();
                    break;
                }

                else
                {
                    Console.WriteLine("Registro de emprestimos vazio!");
                    Console.ReadLine();
                    Console.Clear();
                    return;

                }
            }
        }

       public void MostraRevistasCadastradas()
        {

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] != null)
                {

                    int idRevistas = i;

                    Console.WriteLine("Id do chamado" + idRevistas);

                    Console.WriteLine("coleção da revista : " + revistas[i].strNomecolecaoRevista);

                    Console.WriteLine("numero da edição : " + revistas[i].strNumeroDaEdicao);

                    Console.WriteLine("ano da revista : " + revistas[i].strAnoRevista);

                    Console.WriteLine("cor da caixa esta guardada : ");


                    
                }

                else
                {
                    Console.WriteLine("Registro Vazio!");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
            }
        }
    }

}

