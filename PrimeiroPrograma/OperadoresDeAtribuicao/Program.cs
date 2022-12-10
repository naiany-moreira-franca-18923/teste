using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresDeAtribuicao {
    internal class Program {
        static void Main(string[] args) {
            //Operadores de atribuição
            

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 2;
            Console.WriteLine(a);

            string s = "ABCD";
            Console.WriteLine(s);

            s += "EFGH";
            Console.WriteLine(s);

            //Operadores aritméticos / Atribuição

            int i = 10;

            i++;
            Console.WriteLine(i);

            i--;
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
