using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ativ1Fixacao {
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preço1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($@"Produtos:
{produto1}, cujo o preço é $ " + preço1.ToString("F2"));
            Console.WriteLine("{0}, cujo o preço é {1}", produto2, preco2.ToString("F2"));
            Console.WriteLine(@"
Registro: {0} anos de idade, código {1} e gênero {2} ", idade, codigo, genero);
            Console.WriteLine($@"
Medida com oito casa decimais: {medida:F8}
Arredondando(três casas decimais): {medida:F3}
Separador decimal invariante Culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");


            Console.ReadKey();
        }
    }
}
