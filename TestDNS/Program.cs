using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestDNS
{
    class Program
    {
        static void Main()
        {
            Ping("200.51.211.7", "Telefónica DNS1");
            Ping("200.51.212.7", "Telefónica DNS2");
            Ping("208.67.222.222", "Open DNS1");
            Ping("208.67.220.220", "Open DNS2");
            Ping("8.8.8.8", "Google DNS1");
            Ping("8.8.4.4", "Google DNS2");
            Console.ReadKey();
        }
        static void Ping(string Dns, string Nombre)
        {
            // Abro una nueva instancia de Process para comenzar un proceso
            Process consola = new Process();
            // Establesco que aplicación voy a abrir y con qué argumentos. También establezco que la ventana este oculta
            consola.StartInfo.FileName = "cmd.exe";
            consola.StartInfo.Arguments = "/C ping " + Dns;
            //consola.WindowStyle = ProcessWindowStyle.Hidden;
            consola.StartInfo.UseShellExecute = false;
            consola.StartInfo.ErrorDialog = false;
            consola.StartInfo.CreateNoWindow = true;
            consola.StartInfo.RedirectStandardOutput = true;
            consola.StartInfo.RedirectStandardError = true;
            // Comienzo el Proceso
            consola.Start();

            string salida = consola.StandardOutput.ReadToEnd();
            Console.WriteLine(Nombre);
            Console.WriteLine(salida);
            //Console.ReadKey();
            consola.Close();




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
         */
        }

        
    }
}
