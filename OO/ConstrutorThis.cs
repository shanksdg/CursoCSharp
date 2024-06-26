﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class ConstrutorThis
    {
        public class Animal {
            public string Nome { get; set; }
            public Animal(string nome) {
                Nome = nome;
            }
        }

        public class Cachorro : Animal {
            public double Altura { get; set; }
            public Cachorro(string nome) : base(nome) {
                Console.WriteLine($"Cachorro {nome} Inicializado");

            }
            public Cachorro(string nome, double altura) : this(nome) {
                Altura = altura;
            }
            public override string ToString() {
                return $"{Nome} tem {Altura} cm de Altura";
            }
        }
        public static void Executar() {
            var Spike = new Cachorro("Spike");
            var Max = new Cachorro("Max", 40.0);

            Console.WriteLine(Spike);
            Console.WriteLine(Max);
        }
    }
}
