using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Diego";
            alunos[1] = "Mila";
            alunos[2] = "Vitoria";
            alunos[4] = "Bruna";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.2, 5.7, 8.9, 10, 4.3 };

            foreach ( var nota in notas) {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            Char[] letras = { 'A', 'r', 'r', 'e', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
