using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número");
        double num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        double num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número");
        double num3 = Convert.ToInt32(Console.ReadLine());

        double som = num1 + num2 + num3; 
        double media = som / 3;

        Console.WriteLine($"A média e a soma dos números é {som} e a média é {media}");  
    }
}

