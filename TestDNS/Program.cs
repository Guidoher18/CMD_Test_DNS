using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahora Vamos a Testear la velocidad de conexion con los DNS");
            Console.WriteLine("TELEFÓNICA DNS----------------------");
            Console.WriteLine("ping 200.51.211.7");
            Console.WriteLine("ping 200.51.212.7");

            Console.WriteLine("OPEN DNS ----------------------");
            Console.WriteLine("ping 208.67.222.222");
            Console.WriteLine("ping 208.67.220.220");

            Console.WriteLine("GOOGLE DNS ----------------------");
            Console.WriteLine("ping 8.8.8.8");
            Console.WriteLine("ping 4.4.4.4");
            Console.WriteLine("Presione una Tecla para Salir");
            
            Console.ReadKey();
        }
    }
}
