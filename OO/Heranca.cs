using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtal;

        public Carro(int velocidadeMxima) {
            VelocidadeMaxima = velocidadeMxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtal + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtal = 0;
            }else if (novaVelocidade > VelocidadeAtal) {
                VelocidadeAtal = VelocidadeMaxima;
            }else {
                VelocidadeAtal = novaVelocidade;
            }
            return VelocidadeAtal;
        }
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro {
        public Uno() : base(200) {
        }
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }
        public new int Frear() {
            return AlterarVelocidade(-15);

        }
            
    }
    internal class Heranca
    {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());


            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
             carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
