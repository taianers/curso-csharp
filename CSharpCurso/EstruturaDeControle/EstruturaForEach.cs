using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            /* foreach é usado para percorrer do primeiro até o último elemento sem precisar
            criar uma variável de incremento ou expressão condicional*/
            foreach (var letra in palavra) 
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach (string aluno in alunos) 
            { 
                Console.WriteLine(aluno); 
            }
        }
    }
}
