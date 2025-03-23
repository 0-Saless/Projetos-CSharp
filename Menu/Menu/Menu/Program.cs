using System;
using static System.Console;

class Program
{

    static void Main(string[] args)
    {

        BackgroundColor = ConsoleColor.Black;
        ForegroundColor = ConsoleColor.DarkRed;
        int opc;
        string ctn, imput;
        ctn = null;
        do
        {

            Clear();
            WriteLine("Menu Principal");
            WriteLine("\n[1] - Conta Letras");
            WriteLine("\n[2] - Zenit e Polar");
            WriteLine("\n[3] - Letreiro");
            WriteLine("\n[4] - Desliza Letras");
            WriteLine("\n[5] - Corrige Nomes");
            WriteLine("\n[6] - Fim");
            WriteLine("\nDigite a opção desejada: ");
            imput = ReadLine();
            opc = int.Parse(imput);

           
            if (opc > 6 || opc < 1) 
            {
                do
                {
                    WriteLine("Por favor digite um número válido!!: ");
                    string impu = ReadLine();
                    opc = int.Parse(impu);
                } while (opc > 6 || opc < 1);
            }


            switch (opc)
            {
                case 1:
                    Conta_Letras();
                    break;

                case 2:
                    Zenit_Polar();
                    break;

                case 3:
                    Letreiro();
                    break;

                case 4:
                    Desliza_Letras();
                    break;
                case 5:
                    Corrige_Nomes();
                    break;
            }



        } while (opc != 6);
        if (opc == 6)
        {
            Clear();
            WriteLine("\n\nObrigado por testar nosso programa!!\n\n");
        }

    }

    static void Conta_Letras()
    {
        string vFrase, vLetra, ctn;
        int contA, contE, contI, contO, contU, contC;


        BackgroundColor = ConsoleColor.Black;
        ForegroundColor = ConsoleColor.Red;
        do
        {
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

            WriteLine("\nDeseja Continuar?(S/N)");
            ctn = ReadLine();
        } while (ctn == "s" || ctn == "S");
    }
    static void Zenit_Polar()
    {

        BackgroundColor = ConsoleColor.Black;
        ForegroundColor = ConsoleColor.Yellow;
        string ctn;
        do
        {
            Clear();
            int i2;
            string frase, letra;
            string[,] codigo = new string[,] { { "z", "e", "n", "i", "t" }, { "p", "o", "l", "a", "r" } };

            WriteLine("Digite uma frase ou palavra para criptografar:\n ");
            frase = ReadLine();

            string[] letraf = new string[frase.Length];

            for (int i = 0; i < frase.Length; i++)
            {
                letra = frase.Substring(i, 1).ToLower();
                bool sub = false;

                for (i2 = 0; i2 < 5; i2++)
                {
                    if (letra == codigo[0, i2])
                    {
                        letraf[i] = codigo[1, i2];
                        sub = true;
                        break;
                    }
                    if (letra == codigo[1, i2])
                    {
                        letraf[i] = codigo[0, i2];
                        sub = true;
                        break;
                    }
                }

                if (!sub)
                {
                    letraf[i] = letra;
                }
            }

            WriteLine($"\n\nA frase '{frase}' depois de ser criptografada se torna::\n ");
            for (int i = 0; i < letraf.Length; i++)
            {
                Write(letraf[i]);
            }

            WriteLine("\n\nDeseja Continuar?(S/N)");
            ctn = ReadLine();
        } while (ctn == "s" || ctn == "S");
    }

    static void Letreiro()
    {
        string ctn;
        do
        {
            Clear();
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Informe uma frase: ");
            string vFrase = ReadLine();


            int vTam = vFrase.Length;

            string[] Letreiro = new string[(vTam * 4)];
            for (int i = 0; i < (vTam * 4); i++)
            {
                Letreiro[i] += ' ';
            }

            for (int i2 = 0; i2 < vTam; i2++)
            {
                string vLetra = vFrase.Substring(i2, 1);
                Letreiro[i2] = vLetra;
            }

            int posição = vTam * 3;
            SetCursorPosition(40, 15);
            Write("[");
            SetCursorPosition(posição + 41, 15);
            Write("]");
            do
            {

                for (int i3 = vTam * 3; i3 > 0; i3--)
                {
                    string letra = Letreiro[i3];
                    SetCursorPosition(i3 + 40, 15);
                    Write(letra);

                }
                for (int i4 = 0; i4 < Letreiro.Length - 1; i4++)
                {
                    string troca = Letreiro[i4];
                    Letreiro[i4] = Letreiro[i4 + 1];
                    Letreiro[i4 + 1] = troca;
                }
                Thread.Sleep(45);
            } while (KeyAvailable == false);
            SetCursorPosition(1, 3);
            WriteLine("Deseja continuar? (S/N) ");
            ctn = ReadLine();
        } while (ctn == "s" || ctn == "S");
    }

    static void Desliza_Letras()
    {
        ForegroundColor = ConsoleColor.White;
        string continua;
        do
        {
            Clear();
            WriteLine("Escreva uma frase: ");
            string frase = ReadLine();

            int velocidade = 0;
            if (frase.Length >= 20)
            {
                velocidade = frase.Length / 4;
            }
            else
            {
                velocidade = frase.Length * 5;
            }
            SetCursorPosition(15, 15);
            Write("[");
            SetCursorPosition(61, 15);
            Write("]");
            for (int i2 = 0; i2 < frase.Length; i2++)
            {
                string letra = frase.Substring(i2, 1);

                for (int i = 60; i >= 16 + i2; i--)
                {
                    SetCursorPosition(i, 15);
                    Write(letra);
                    Thread.Sleep(velocidade);
                    if (i > 16 + i2)
                    {
                        SetCursorPosition(i, 15);
                        Write(" ");
                    }
                }
            }

            SetCursorPosition(0, 4);
            WriteLine("Deseja continuar? ");
            continua = ReadLine();
            continua = continua.ToUpper();
        } while (continua == "S");
    }

    static void Corrige_Nomes()
    {
        ForegroundColor = ConsoleColor.Yellow;
        BackgroundColor = ConsoleColor.Black;
        string continua;
        do
        {
            
            Clear();

            Write("Escreva um nome: ");
            string vNome = ReadLine();

            vNome = vNome.ToUpper();
            string[] vNomeComp = vNome.Split(' ');
            int vTamLetra2 = vNomeComp.Length;
            for (int i = 0; i < vTamLetra2; i++)
            {
                string vLetra = vNomeComp[i].Substring(0, 1);
                string vNomeComp2 = vLetra + vNomeComp[i].Substring(1).ToLower();

                if (vNomeComp[i] == "DOS" || vNomeComp[i] == "DO" || vNomeComp[i] == "DAS" || vNomeComp[i] == "DA" || vNomeComp[i] == "E")
                {
                    vNomeComp2 = vNomeComp[i].ToLower();
                }

                Write(vNomeComp2 + " ");
            }
            SetCursorPosition(0, 4);
            WriteLine("Deseja continuar? ");
            continua = ReadLine();
            continua = continua.ToUpper();
        } while (continua == "S");










    }


}