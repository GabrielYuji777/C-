//Exercício 01
using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Configurar o console para apresentar o utf8
        Console.OutputEncoding = Encoding.UTF8;

        // Solicitar nome de usuário
        Console.Write("Olá, qual seu nome? ");
        string nome = Console.ReadLine();

        // Imprimindo no terminal
        Console.WriteLine($"Olá, {nome}! você é especial!");
    }
}
