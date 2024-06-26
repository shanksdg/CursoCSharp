﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é" + area);

            // tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Ésta Chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario" + salario);

            int menorValorInt = int.MinValue; // mais usado dos inteiros!
            Console.WriteLine("Menor int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial" + populacaoMundial);
            
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador" + precoComputador);

            double valorDeMercadoDaAplle = 1_000_000_000_000.00; // Mais usados dos reais;
            Console.WriteLine("Valor Aplle" + valorDeMercadoDaAplle);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia Entre Estrelas" + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra" + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);

        }
    }
}
