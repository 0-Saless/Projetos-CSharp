using System;
using static System.Console;
class Program
{

    static void Main(string[] args)
    {

        int i2;
        string frase, letra;
        string[,] codigo = new string[,] { { "z", "e", "n", "i", "t" }, { "p", "o", "l", "a", "r" } };

        WriteLine("Digite uma frase ou palavra: ");
        frase = ReadLine();

        string[] letraf = new string[frase.Length];

        for (int i = 0; i < frase.Length; i++)
        {
            letra = frase.Substring(i, 1).ToLower();
            bool substituida = false;

            for (i2 = 0; i2 < 5; i2++)
            {
                if (letra == codigo[0, i2])
                {
                    letraf[i] = codigo[1, i2];
                    substituida = true;
                    break;
                }
                if (letra == codigo[1, i2])
                {
                    letraf[i] = codigo[0, i2];
                    substituida = true;
                    break;
                }
            }

            if (!substituida)
            {
                letraf[i] = letra;
            }
        }

        WriteLine("A frase criptografada é: ");
        for (int i = 0; i < letraf.Length; i++)
        {
            Write(letraf[i]);
        }
    }

}
