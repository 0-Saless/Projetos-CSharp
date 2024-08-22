using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string vFrase, vLetra;
        int contA, contE, contI, contO, contU, contC;
        
        
        BackgroundColor = ConsoleColor.Black;
        ForegroundColor = ConsoleColor.Green;
       
        Clear();

        Write("Digite sua frase: ");
        vFrase = ReadLine();
        int vTam = vFrase.Length;
        contA = 0; contE = 0; contI = 0; contO = 0; contU = 0; contC = 0;
        for (int i = 0; i < vTam; i++)
        {
            vLetra = vFrase.Substring(i, 1);
            switch (vLetra.ToLower())
            {
                case "a":
                    contA++;
                    break;

                case "e":
                    contE++;
                    break;

                case "i":
                    contI++;
                    break;

                case "o":
                    contO++;
                    break;

                case "u":
                    contU++;
                    break;

                case " ":
                    break;

                case ",":
                    break;

                case ".":
                    break;

                case "!":
                    break;

                case "?":
                    break;
                case "  ":
                    break;
                case "0":
                    break;

                case "1":
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "6":
                    break;

                case "7":
                    break;

                case "8":
                    break;

                case "9":
                    break;
                default:
                    contC++;
                    break;
            }
        }
       
        
        WriteLine($"\nNa sua frase existem {contA} letras 'A'");
        WriteLine($"Na sua frase existem {contE} letras 'E'");
        WriteLine($"Na sua frase existem {contI} letras 'I'");
        WriteLine($"Na sua frase existem {contO} letras 'O'");
        WriteLine($"Na sua frase existem {contU} letras 'U'");
        WriteLine($"Na sua frase existem {contC} consoantes");
        WriteLine($"No total,existem {vTam} caracteres na sua  frase");
    }
}
