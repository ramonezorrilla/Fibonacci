using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número para comenzar la serie Fibonacci:");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Serie Fibonacci:");
        for (int i = 0; i < numero; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}