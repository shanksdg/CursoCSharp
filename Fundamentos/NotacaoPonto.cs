using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " world!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorimpotante = null;
            Console.WriteLine(valorimpotante?.Length);
        }

    }
}
