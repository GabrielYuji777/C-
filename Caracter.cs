//programa que éça ao usuário para inserir um caracter e exibe, em seguida, esse caracter de quatro encondig diferentes
using System;

class Representacaodecaracter
{
    static void Main();
    {
        //Solicitação ao usuário de um caracter
        Console.WriteLine("Digite um caractere: ");
        char caracter= Console.ReadKey(): KeyChar();
        Console.WriteLine();
    
        //Conversão do caracter conforme o enunciado
        string unicodeRepresent= $"\\u{(int)caracter:X4}";

        string hexadecRepresent = $"\\x{(int)caracter:X4}";

        int representacao = (int)caracter;

        //Exibição das representações

        Console.WriteLine('$Caractere Literal: '{caracter}'');
        Console.WriteLine('$Representação Unicode: '{unicodeRepresent}'');
        Console.WriteLine('$representação Hexadecimal: '{hexadecRepresent}'');
        Console.WriteLine('$Representação como Inteiro: '{representacao}'');
    }
}
