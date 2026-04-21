using System.Diagnostics;

namespace GestionProcessus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process p =new Process();

            p.StartInfo.FileName = @"C:\Users\basan\OneDrive\Documents\Desktop\2em Q2\LABEYE\GestionProcessus\PgmSecondaire\bin\Debug\net8.0\PgmSecondaire.exe";
            p.StartInfo.UseShellExecute =false;
            p.StartInfo.RedirectStandardInput = true;       
            p.StartInfo.RedirectStandardOutput = true;  

            //DateTime start = DateTime.Now;
            p.Start();

            p.StandardInput.WriteLine("BASANT");
            p.StandardInput.WriteLine("ALBASHITI");

            string result= p.StandardOutput.ReadToEnd();
            Console.WriteLine(result);

            p.WaitForExit();


        }
    }
}
