using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            // Preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var valorTotalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", valorTotalComDesconto);

            //IMC
            //Console.WriteLine("Digite seu peso: ");
            //double peso = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite sua altura: ");
            //double altura = double.Parse(Console.ReadLine());
            //double imc = peso / (altura * altura);
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC é {imc}.");

            // Número par/ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
