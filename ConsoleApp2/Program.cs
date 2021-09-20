using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = "emptyTexta_a3b9aa4a8dfcc447abd8229c472acff56.txt";
            string[] k = s.Split('.');
            int t = Convert.ToInt32(k.Length);
            string extension = k[t - 1];
            int exra =  35 + 1 + extension.Length;
            int nameLen = s.Length - exra;
            string fileName = s.Substring(0, nameLen);
            string dateTime = string.Format(" {0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
            fileName = fileName + dateTime + "." + extension;
            Console.WriteLine(fileName);
            

                
        }
    }
}
