using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);
        string op = Console.ReadLine()!;

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                if (op == "+")
                {
                    Console.Write($"{i} + {j} = {i + j}\t");
                }
                else if (op == "-")
                {
                    Console.Write($"{i} - {j} = {i - j}\t");
                }
                else if (op == "*")
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                else if (op == "/")
                {
                    Console.Write($"{i} / {j} = {((double)i / j):F2}\t");
                }
            }
            
            Console.WriteLine();
        }
    }
}
