using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ip_y_DNS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                /*Ping("200.51.211.7", "Telefónica DNS1:");
                Ping("200.51.212.7", "Telefónica DNS2:");
                Ping("208.67.222.222", "Open DNS1:");
                Ping("208.67.220.220", "Open DNS2:");
                Ping("8.8.8.8", "Google DNS1:");
                Ping("8.8.4.4", "Google DNS2:");
                Ipconfig();
                Console.WriteLine("Presione una tecla para salir...");
                Console.ReadKey();*/
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
                Console.WriteLine(Nombre + " " + Dns);
                // Busco en la salida del Ping la última "a" de Media = 98 ms
                int indice = salida.LastIndexOf('a');
                indice = indice - 4;
                // Obtendo el Media = 98 ms
                salida = salida.Substring(indice);
                Console.WriteLine(salida);
                consola.Close();

            }

        static void Ipconfig()
            {
                // Inicio una nueva instancia de Process para comenzar un proceso
                Process consola = new Process();

                // Establezco que aplicación voy a abrir y con qué argumentos.
                consola.StartInfo.FileName = "cmd.exe";
                consola.StartInfo.Arguments = "/C ipconfig/all";
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

                Console.WriteLine(salida);
                consola.Close();

            }

     }
}

