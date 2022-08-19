using System.ComponentModel;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ekranda girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.Write("lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

// Aşağıda yaptığımız işlem  1 den 1000 kadar olan tek ve çift sayıların toplamını yazdıran kod
            int TekToplam = 0;
            int CiftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    TekToplam += i;
                }
                else
                {
                    CiftToplam += i;
                }

            }

            Console.WriteLine("Tek Toplam:" + TekToplam);
            Console.WriteLine("Çift Toplam:" + CiftToplam);

            // Break, continue

            // Break = yaptığımız döngünde istediğim yerde durmasını sağlamak için bu komut kullanılır.
            //continue = bu komut ise devam etmesi için kullanılır.

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break; // Burada 1 den 10 kadar olan sayıları yazdıracaktır. biz ise 4 de durması gerektiğini söylüyoruz.

                }

                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue; // Burada ise 4 den sonra tekrar baştan sayması gerektiğini söylüyrouz.

                }

                Console.WriteLine(i);
            }
        }
    }
    
}

