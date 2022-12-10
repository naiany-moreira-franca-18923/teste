using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 19;
            double saldo = 18598.58978;
            string nome = "Charlotte Seymour";

            // Placeholders

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.",nome,idade,saldo);

            // Concatenação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            // Interpolação

            Console.WriteLine($"{nome} tem {idade} anos e ten saldo igual a {saldo:F2} reais");

            Console.ReadKey();
        }
    }
}