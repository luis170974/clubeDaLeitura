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
            Menu menu = new Menu();

            while (true) { 
            menu.MostraMenu();
            }
        }
    }
}
