using System.Diagnostics;

namespace GestionProcessus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process p =new Process();

            p.StartInfo.FileName = @"C:\Users\basan\OneDrive\Documents\Desktop\2em Q2\LABEYE\GestionProcessus\PgmSecondaire\bin\Debug\net8.0\PgmSecondaire.exe";
            p.StartInfo.FileName = "notepad.exe";

            //DateTime start = DateTime.Now;
            p.Start();

            Console.WriteLine("Appuyez sur ENTER pour fermer Notepad...");
            Console.ReadLine();

            Console.WriteLine("HasExited = " + p.HasExited);

            if (!p.HasExited)
            {
                p.Kill();
                Console.WriteLine("Notepad fermé !");
            }
            else
            {
                Console.WriteLine("Notepad était déjà fermé.");

            }
        }
    }
}
