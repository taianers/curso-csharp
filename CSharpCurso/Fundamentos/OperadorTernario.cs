using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.Fundamentos {
    class OperadorTernario {

        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = true;
            // expressão condicional? primeiro operando verdadeiro : segundo operando falso
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado"; // atribuição condicional mesmo tipo
            Console.WriteLine(resultado);
        }
    }
}
