using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente {
        public string Nome;
        public int Idade;

    }
    internal class ValorVsReferencia
    {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Dieg0",
                Idade = 19
            };
            Dependente copiadep = dep;
            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");

            copiadep.Nome = "Pedro";
            dep.Idade = 20;

            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");
        }
    }
}
