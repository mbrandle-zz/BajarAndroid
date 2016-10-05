using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace BajarAndroid
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Iniciando Baja De Fotografias....");


                Console.WriteLine("Iniciando Bajada de Datos....");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c adb pull /mnt/sdcard/Lecturas/Lect1.txt C:\\facturacion";
                process.StartInfo = startInfo;
                process.Start();

                var stopwatch = Stopwatch.StartNew();
                Thread.Sleep(10000);
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
                Console.WriteLine(DateTime.Now.ToLongTimeString());


                Console.WriteLine("Iniciando Descarga de Imagenes....");
                System.Diagnostics.Process processFotos = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfoFotos = new System.Diagnostics.ProcessStartInfo();
                startInfoFotos.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfoFotos.FileName = "cmd.exe";
                startInfoFotos.Arguments = startInfo.Arguments = "/c adb pull /mnt/sdcard/Lecturas/Fotografias C:\\facturacion\\Fotografias";
                processFotos.StartInfo = startInfoFotos;
                processFotos.Start();

                stopwatch = Stopwatch.StartNew();
                Thread.Sleep(10000);
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
                Console.WriteLine(DateTime.Now.ToLongTimeString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            finally
            {
                System.Environment.Exit(0);
            }
        }
    }
}
