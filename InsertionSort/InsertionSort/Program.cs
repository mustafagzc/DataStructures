using System;

namespace InsertionSort
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 7, 11, 85, 58, 63, 99, 103, 21, 54, 31 };
            Console.WriteLine("Sırlamadan Önceki Dizi: ");
            foreach (int x in dizi)
            Console.Write(x + " ");
            
            Console.WriteLine("\n");
            
            Sıralama.InsertionSort(dizi);
            Console.WriteLine("Sıralanmış Dizi :");
            foreach (int x in dizi)
            Console.Write(x + " ");


        }
    }
    class Sıralama
    {
        public static void InsertionSort(int[] pdizi) //pdizi = parametre dizi
        {
            int k, j;
            for (int i = 1; i <pdizi.Length; i++)
            {
                j = pdizi[i];
                k = i - 1;
                while (k>=0 && pdizi[k]>j)
                {
                    pdizi[k + 1] = pdizi[k];
                    k--;
                }
                pdizi[k + 1] = j;
            }
        }
    }
}
