﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Que feio!!");
            }
        }
    }
}
