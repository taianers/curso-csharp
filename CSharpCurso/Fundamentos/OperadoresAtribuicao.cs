using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.Fundamentos{
    class OperadoresAtribuicao{
        public static void Executar(){
            var num1 = 3;
            num1 = 7; // substitui de 3 para 7
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5; // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1; // atribuição de valor literal
            int b = a; // atribuição de outra variável (por cópia/referência)

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}");
        }
    }
}
