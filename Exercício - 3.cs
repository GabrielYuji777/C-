using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<decimal> Notas = new List<decimal>();

        Console.WriteLine("Qual é o seu nome?");
        string nomeFuncionario = Console.ReadLine();

        Console.WriteLine("Qual é a sua idade:");
        string idadeAlunoString = Console.ReadLine();
        int idade;
        if (int.TryParse(idadeAlunoString, out idade))
        {
            Console.WriteLine($"Idade do aluno: {idade}");
        }

        Console.WriteLine("Digite sua nota em Português:");
        decimal notaPortugues = ConverterParaDecimal(Console.ReadLine());

        Console.WriteLine("Digite sua nota em Matemática:");
        decimal notaMatematica = ConverterParaDecimal(Console.ReadLine());

        Notas.Add(notaPortugues);
        Notas.Add(notaMatematica);

        decimal media = (notaPortugues + notaMatematica) / 2;
        string resultado = media > 6.0m ? "Aprovado" : "Reprovado";
        Console.WriteLine($"O aluno {nomeFuncionario} está {resultado}.");

        Console.WriteLine("O aluno possui bolsa de estudos? Digite somente (Sim / Não):");
        string respostaBolsa = Console.ReadLine().Trim().ToLower();
        bool bolsa = respostaBolsa == "sim";

        if (bolsa && media < 8.0m)
        {
            Console.WriteLine("O aluno perdeu a bolsa de estudos.");
        }

        decimal mediaFinal = CalcularMedia(Notas);
        Console.WriteLine($"A média das notas dos alunos é {mediaFinal:F2}");

        Console.WriteLine("Deseja adicionar outro aluno? (Sim/Não):");
        if (Console.ReadLine()?.Trim().ToLower() != "sim")
        {
            return;
        }
        Console.Clear();
    }


    static decimal ConverterParaDecimal(string input)
    {
        decimal resultado;
        if (decimal.TryParse(input, out resultado))
        {
            return resultado;
        }
        else
        {
            Console.WriteLine("Nota inválida. Considerando nota 0.");
            return 0m;
        }
    }

    static decimal CalcularMedia(List<decimal> notas)
    {
        if (notas.Count == 0)
        {
            return 0m;
        }
        decimal soma = 0;
        foreach (decimal nota in notas)
        {
            soma += nota;
        }
        return soma / notas.Count;
    }
}
