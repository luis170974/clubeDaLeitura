using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{

    public class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {

                Menu MenuPrincipal = new Menu();

                MenuPrincipal.MostraMenuEValida();

                MenuPrincipal.ValidaOpcoes();



            }

        }

        
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