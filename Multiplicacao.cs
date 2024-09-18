using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <=10; i++) {
            Console.WriteLine($"{num + i}");
        }
    }
}
