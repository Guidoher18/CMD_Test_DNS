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
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static void Ping(string Dns, string Nombre)
        {
            // Inicio una nueva instancia de Process para comenzar un proceso
            Process consola = new Process();
            
            // Establezco que aplicación voy a abrir y con qué argumentos.
            consola.StartInfo.FileName = "cmd.exe";
            consola.StartInfo.Arguments = "/C ping " + Dns;
            consola.StartInfo.UseShellExecute = false;
            consola.StartInfo.ErrorDialog = false;
            
            //El proceso sucede oculto para el usuario
            consola.StartInfo.CreateNoWindow = true;
            
            // Tomo el output y lo redirijo 
            consola.StartInfo.RedirectStandardOutput = true;
            consola.StartInfo.RedirectStandardError = true;
            
            // Comienzo el Proceso
            consola.Start();

            //Escribo en la consola el resultado
            string salida = consola.StandardOutput.ReadToEnd();
            Console.WriteLine(Nombre);
            Console.WriteLine(salida);
            consola.Close();

        }

        
    }
}
