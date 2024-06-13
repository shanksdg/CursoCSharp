using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar() {
            Action algonoConsole = () => {
                Console.WriteLine("Lmabda com C#!");
            };

            algonoConsole();

            Func<int> jogardado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogardado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2024));
        }

    }
}
