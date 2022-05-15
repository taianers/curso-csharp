using System;
using System.Globalization;
namespace CSharpCurso.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //casa decimal
            Console.WriteLine(valor.ToString("C")); // valor monetario
            Console.WriteLine(valor.ToString("P")); // valor percentual
            Console.WriteLine(valor.ToString("#.##")); // valor específico

            CultureInfo cultura = new CultureInfo("pt-br"); // formatação de cultura
            Console.WriteLine(valor.ToString("C2", cultura));
            CultureInfo culturaEn = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", culturaEn));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
