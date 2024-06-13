using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeinteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeinteiro);

            idadeinteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}",idadeinteiro);

            Console.Write("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
