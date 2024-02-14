using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv i ett tal");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv i ett tal");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv i ett tal");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Summan av de tre talen blir "+Addera(a,b,c));
    }
    static int Addera(int a, int b, int c)
    {
        return a + b+ c;
    }
}