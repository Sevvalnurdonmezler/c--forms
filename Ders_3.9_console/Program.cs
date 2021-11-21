using System;

namespace Ders_3._9_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;
            while (sayi != 0)
            {
                Console.WriteLine("Bir sayı Giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Bitti...");
                Console.ReadLine();
        }
    }
}
