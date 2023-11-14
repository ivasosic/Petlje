﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- 1. zadatak --");
            for (int i = 1900-1; i<=2100; i++)
            {
                if(i%400==0 || (i%4==0 && i % 100 != 0))
                {
                    Console.WriteLine("Prijestupna godina: "+i);
                }
            }
            Console.WriteLine("-- 3. zadatak --");
            Console.Write("Unesite 1. broj: ");
            int br1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite 2. broj: ");
            int br2 = Convert.ToInt32(Console.ReadLine());

            int largestCommonDivisor = FindLargestCommonDivisor(br1, br2);
            Console.WriteLine("Najveći broj s kojim su oba broja djeljiva je: " + largestCommonDivisor + ".");
            Console.ReadKey();
        }
        static int FindLargestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b; Console.WriteLine("temp=b: " + temp);
                b = a % b; Console.WriteLine("b=a%b: " + b);
                a = temp; Console.WriteLine("a=temp: " + a + "\n");
            }
            return a;

            Console.ReadKey();
        }
    }
}