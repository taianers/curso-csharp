﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Tamanho".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // ? só executa a variável se o valor está definido
        }
    }
}
