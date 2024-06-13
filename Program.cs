using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasdeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadore Ternario  - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estruturas If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estruturas If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estruturas If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estruturas Swith - Estruturas de Controle", EstruturaSwith.Executar},
                {"Estruturas While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estruturas DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estruturas For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estruturas Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readomly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct Vs Classes - Classes e Métodos", StructVsClass.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência  - Classes e Métodos",ParametrosPorReferencia.Executar},
                {"Parâmetro Padrão - Classes e Métodos",ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Coleções Stack - Coleções", ColecoesStack.Executar },
                {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar },


                //OO
                {"Herança - OO", Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", OO.Polimorfismo.Executar },
                {"Abstract - OO", OO.Abstract.Executar },
                {"Interface - OO", OO.Interface.Executar },
                { "Sealed - OO", OO.Sealed.Executar },


                //Metodos e Funcoes
                { "Exemplo Lambda - Metodos e Funcoes",ExemploLambda.Executar },
                { "Lambdas Como Delegates - Metodos e Funcoes",LambdaDelegates.Executar },
                { "Usando Delegates - Metodos e Funcoes",UsandoDelegates.Executar },
                { "Delegates Funções Anonimas - Metodos e Funcoes",DelegateFunAnonima.Executar },
                { "Delegates Como Parametros - Metodos e Funcoes",DelegateComoParametros.Executar },
                { "Metodos de Extensão - Metodos e Funcoes",MetodosDeExtensao.Executar },
                
                
                //Excecoes
                { "Primeira Exceção - Exceções",PrimeiraExcecao.Executar },
                { "Exceções Personalizadas - Exceções",ExcecoesPersonalizadas.Executar },
                
                
                //Api
                { "Primeiro Arquivo - Api",PrimeiroArquivo.Executar },
                { "Lendo Arquivo - Api",LendoArquivos.Executar },
                { "Exemplo File Info - Api",ExemploFileInfo.Executar },
                { "Diretorios - Api",Diretorios.Executar },
                { "Exemplo Directory Info - Api",ExemploDirectoryInfo.Executar },
                { "Exemplo Path Info - Api",ExemploPath.Executar },
                { "Exemplo DateTime - Api",ExemploDateTime.Executar },
                { "Exemplo TimeSpan - Api",ExemploTimeSpan.Executar },



            });

            central.SelecionarEExecutar();
        }
    }
}