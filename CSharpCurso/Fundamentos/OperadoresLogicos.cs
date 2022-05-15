using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrab1 = true;
            var executouTrab2 = false;

            bool comprouTV50 = executouTrab1 && executouTrab2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50);

            var comprouSorvete = executouTrab1 || executouTrab2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrab1 ^ executouTrab2; // ou exclusívo
            Console.WriteLine("Comprou a TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
