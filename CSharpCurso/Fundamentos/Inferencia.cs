using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Taiane";
            // nome = 123; não pode pois houve uma inferencia, foi detectado que a variavel é uma string
            Console.WriteLine(nome);

            // int idade
            var idade = 23;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a+b);
        }
    }
}
