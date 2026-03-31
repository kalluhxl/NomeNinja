using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Nome Ninja ---\n");

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine().ToUpper();

        string resultado = "";

        foreach (char letra in nome)
        {
            switch (letra)
            {
                case 'A': resultado += "KA"; break;
                case 'B': resultado += "ZU"; break;
                case 'C': resultado += "MI"; break;
                case 'D': resultado += "TE"; break;
                case 'E': resultado += "KU"; break;
                case 'F': resultado += "LU"; break;
                case 'G': resultado += "JI"; break;
                case 'H': resultado += "RI"; break;
                case 'I': resultado += "KI"; break;
                case 'J': resultado += "ZUS"; break;
                case 'K': resultado += "ME"; break;
                case 'L': resultado += "TA"; break;
                case 'M': resultado += "RIN"; break;
                case 'N': resultado += "TO"; break;
                case 'O': resultado += "MO"; break;
                case 'P': resultado += "NO"; break;
                case 'Q': resultado += "KE"; break;
                case 'R': resultado += "SHI"; break;
                case 'S': resultado += "ARI"; break;
                case 'T': resultado += "CHI"; break;
                case 'U': resultado += "DO"; break;
                case 'V': resultado += "RU"; break;
                case 'W': resultado += "MEI"; break;
                case 'X': resultado += "NA"; break;
                case 'Y': resultado += "FU"; break;
                case 'Z': resultado += "ZI"; break;
            }
        }

        Console.WriteLine("\nSeu nome ninja é " + resultado);
    }
}
