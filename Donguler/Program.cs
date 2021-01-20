using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "CPLUS";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "Temel Kurs", "Java","Python","CPLUS" };

            for (int i = 0; i<kurslar.Length; i=i+2)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For biddu");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");
                
        } 
    }
}
