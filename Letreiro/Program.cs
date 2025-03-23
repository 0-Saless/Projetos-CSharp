using System;
using static System.Console;
class Letreiro
{
    static void Main(string[] args)
    {
        WriteLine("Informe uma frase: ");
        string vFrase = ReadLine();
        

        int vTam = vFrase.Length;  
        string espaços = new string(' ',(vTam*3));

        string[] Letreiro = new string[(vTam*4)];
        for (int i = 0; i < (vTam*3); i++)
        {
            Letreiro[i] += ' ';
        }
       
        for (int i2 = 0; i2 < vTam; i2++)
        {
            string vLetra = vFrase.Substring(i2,1);
            Letreiro[i2] += vLetra;
        }
        for (int i3 = 0; i3 < Letreiro.Length; i3++)
        {
            for (int x = (Letreiro.Length - 1); x > 0; x--)
            {
                string troca = Letreiro[x];
                Letreiro[x] = Letreiro[x - 1];
                Letreiro[x-1] = troca;
            }


        }
        WriteLine(Letreiro[(vTam*4)]);


    }
}
