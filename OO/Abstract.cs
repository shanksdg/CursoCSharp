using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim";
        }
    }
    public class Sansung : Celular {
        public override string Assistente() {
            return "Olá!,Meu nome e Bixby!";
        }
    }
    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri!";
        }
    }
    internal class Abstract
    {
        public static void Executar() {
            var celulares = new List<Celular>{
                new Iphone(),
                    new Sansung()
            };
            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
