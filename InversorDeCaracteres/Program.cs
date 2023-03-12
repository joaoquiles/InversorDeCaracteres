using System;

class Program
{
    static void Main(string[] args)
    {
        string str, invertida = "";
        int i;

        Console.Write("Digite uma string: ");
        str = Console.ReadLine();

        for (i = str.Length - 1; i >= 0; i--)
        {
            invertida += str[i];
        }

        Console.WriteLine("String invertida: {0}", invertida);
    }
}