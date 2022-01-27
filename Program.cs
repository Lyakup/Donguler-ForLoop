using System;

namespace Donguler_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz");
            int sayac = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= sayac; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }



            int tekSayilarToplami = 0;
            int ciftSayilarToplami = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i % 2 == 1)
                {
                    tekSayilarToplami += i;
                }
                else
                {
                    ciftSayilarToplami += i;
                }
            }

            Console.WriteLine("Tek Toplam: " + tekSayilarToplami);
            Console.WriteLine("Çift Toplma: " + ciftSayilarToplami);


            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
