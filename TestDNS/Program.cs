using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDNS
{
    class Program
    {
        static void Main()
        {

            ProcessStartInfo consola = new ProcessStartInfo();
            consola.FileName = "cmd.exe";
            consola.Arguments = "/C ping 200.51.211.7";
            consola.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(consola);
          
            /*Process.Start("cmd.exe", );
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

         /*static void ExecuteCommand()
         {
             //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
             //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
             //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
             ProcessStartInfo consola = new ProcessStartInfo("cmd.exe", "ping 200.51.211.7");
             // Indicamos que la salida del proceso se redireccione en un Stream
             consola.RedirectStandardOutput = true;
             consola.UseShellExecute = true;
             //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
             consola.CreateNoWindow = false;
             //Inicializa el proceso
             Process proc = new Process();
             proc.StartInfo = consola;
             proc.Start();
             //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
             string result = proc.StandardOutput.ReadToEnd();
             //Muestra en pantalla la salida del Comando
             Console.WriteLine(result);
             Console.ReadKey();
         }


         static void Main(string[] args)
         {
             /*Console.WriteLine("Ahora Vamos a Testear la velocidad de conexion con los DNS");
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

             Console.ReadKey();*/
        }
    }
}
