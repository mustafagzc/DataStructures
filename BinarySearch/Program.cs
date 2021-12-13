using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 75, 78, 9654 };
            int baslangıc = 0;
            int bitis = dizi.GetUpperBound(0);//dizinin en son indisini verir. yani dizideki en büyük değerin indisini verir.
            int orta = (baslangıc + bitis) / 2;
            Console.Write("sayi girin : ");
            int arananSayi = int.Parse(Console.ReadLine());
            Boolean bulundumu = false;

            while (bitis - baslangıc > 1) //dizide tek eleman kalınca döngü biter.
            {
                orta = (baslangıc + bitis) / 2;

                if (dizi[orta] > arananSayi)
                {
                    bitis = orta;
                }
                else if (dizi[orta] < arananSayi)
                {
                    baslangıc = orta;
                }
                else
                {
                    Console.WriteLine("dizi içinde böyle bir sayı var. " + orta + ".indisde");
                    bulundumu = true;
                    break;
                }
            }
            if (bulundumu == false)
            {
                Console.WriteLine("sayı bulunamadı");
            }

            Console.Read();
        }
    }
}
