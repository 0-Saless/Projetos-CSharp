using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string vFrase, vLetra;
        int contA, contE, contI, contO, contU, contC;
        ForegroundColor = ConsoleColor.Green;
        BackgroundColor = ConsoleColor.Black;
        Clear();

        Write("Escreva uma frase: ");
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

                case "  ":
                    break;

                default:
                    contC++;
                    break;
            }
        }
        WriteLine($"\nNessa frase há {contA} letras A");
        WriteLine($"Nessa frase há {contE} letras E");
        WriteLine($"Nessa frase há {contI} letras I");
        WriteLine($"Nessa frase há {contO} letras O");
        WriteLine($"Nessa frase há {contU} letras U");
        WriteLine($"Nessa frase há {contC} consoantes");
        WriteLine($"Existem {vTam} caracteres na frase");
    }
}
