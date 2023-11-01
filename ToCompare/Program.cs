// See https://aka.ms/new-console-template for more information
/*
 Ekrandan girilen n tane integer ikililerin toplamını alan, 
eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, 
sayılar aynıysa toplamının karesini ekrana yazdıran console 
uygulamasını yazınız.

Örnek Input: 2 3 1 5 2 5 3 3

Output: 5 6 7 81
 */
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Lutfen tam sayı ikiliklerini boşluklarla girin(örn. 2 3 1 5 2 5 3 3)");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        List<int> results = new List<int>();
        for(int i = 0; i < numbers.Length; i += 2)
        {
            int num1 = int.Parse(numbers[i]);
            int num2 = int.Parse(numbers[i + 1]);
            if (num1 != num2)
            {
                int sum = num1 + num2;
                results.Add(sum);
            }
            else
            {
                int square = num1 * num2;
                int kare = (int)Math.Pow(square, 2);
                results.Add(kare);
            }
        }
        Console.WriteLine("Sonuçlar:");
        foreach(int result in results)
        {
            Console.Write(result + " ");
        }
    }
}