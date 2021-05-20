using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi", "köpek", "kuş"};

            renkler[0] = "Mavi";

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lütfen {0}. sayıyı giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

                int toplam =0;
                foreach (var sayi in sayiDizisi)
                {
                    toplam += sayi;
                    Console.WriteLine("Ortalama" + toplam/diziUzunlugu);
                }
            }
        }
    }
}
