using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Giriş";
            string kurs3 = "Java";

            //array - dizi 

            string[] kurslar = new string[] 
            {
                "Yazılım Geliştirici Kampı",
                "Programlamaya Giriş",
                "Java",
                "Python",
                "C#"
            };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
