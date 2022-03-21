using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubeDaLeitura.ConsoleApp
{
    public class Reservas
    {
        public Reservas[] reservarRevista = new Reservas[10];
        public Revista revista;
        public Amigo amigo;
        public int expira = 2;
        public DateTime dataExpirar = DateTime.MinValue;
        public int contadorReserva = 0;

        public void CadastrarReserva()
        {
            reservarRevista[contadorReserva] = new Reservas();

            Console.WriteLine("Qual o amigo que ira fazer a reserva : ");
            int idAmigoReserva = int.Parse(Console.ReadLine());
            reservarRevista[contadorReserva].amigo = amigo.registroAmigo[idAmigoReserva];

            Console.WriteLine("Qual a revista será reservada : ");
            int idRevistaReserva = int.Parse(Console.ReadLine());
            reservarRevista[contadorReserva].revista = revista.registroRevistas[idRevistaReserva];

            reservarRevista[contadorReserva].dataExpirar = DateTime.Now.AddDays(reservarRevista[contadorReserva].expira);

            contadorReserva++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reserva cadastrada com sucesso");
            Console.ResetColor();
            Console.Clear();

        }

        public void MostrarReservas()
        {
            if (contadorReserva == 0)
            {
                Console.WriteLine("Registro Vazio!");
                Console.ReadLine();
                Console.Clear();
                return;

            }
            for (int i = 0; i < contadorReserva; i++)
            {


                Console.WriteLine("Id da reserva : " + i);

                Console.WriteLine("amigo que reservou : " + reservarRevista[i].amigo);

                Console.WriteLine("revista que reservou : " + reservarRevista[i].revista);

                Console.WriteLine("data que expira a reserva : " + reservarRevista[i].dataExpirar);



                break;



            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
