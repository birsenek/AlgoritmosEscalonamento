using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosEscalonamento
{
    class RoundRobin
    {
        public static void OrdenarRoundRobin()
        {
            int qtdeProcessos = 0;
            int contProcessos = 0;
            double quantum;
            bool isQuantum = false;
            bool validarInteiro = false;

            Console.WriteLine("Você escolheu:");
            Console.WriteLine("4 - Algorítmo Round Robin");
            Console.WriteLine("Quantos processos serão analisados?");

            while (validarInteiro == false)
            {
                try
                {
                    qtdeProcessos = Convert.ToInt32(Console.ReadLine());
                    validarInteiro = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira um valor numérico.");
                }

            }

            var processos = new List<Processo> { };

            Console.WriteLine("Insira o Nome e o Tempo médio de execução de cada processo que será analisado");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Processo _processo = new Processo();
                Console.WriteLine("\nNome do Processo:");
                _processo.nome = Console.ReadLine();
                Console.WriteLine("Tempo Médio de processamento:");

                validarInteiro = false;
                while (validarInteiro == false)
                {
                    try
                    {
                        _processo.tempoProcesso = Convert.ToDouble(Console.ReadLine());
                        validarInteiro = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Insira um valor numérico.");
                    }
                }
                
                processos.Add(_processo);
            }

            Console.WriteLine("\nInsira o Quantum:");
            quantum = Convert.ToDouble(Console.ReadLine());

            //ordenar processos
            //round robin os processos são listados por ordem de entrada 
            //troca de contexto de acordo com o quantum

            Console.WriteLine("\nOrdem de Execução:\n");

            while (isQuantum == false)
            {
                for (int i = 0; i < qtdeProcessos; i++)
                {
                    contProcessos++;
                    if (processos[i].tempoProcesso > quantum)
                    {
                      
                        Console.WriteLine("Processo {0}: {1}, Tempo restante de execução: {2}", contProcessos, processos[i].nome, processos[i].tempoProcesso);
                        processos[i].tempoProcesso -= quantum;
                    }
                    else
                    {
                        Console.WriteLine("Processo {0}: {1}, Tempo de execução: {2}", contProcessos, processos[i].nome, processos[i].tempoProcesso);
                        processos[i].isRemovable = true;
                    }
                }

                for (int i = 0; i < qtdeProcessos; i++)
                {
                    if (processos[i].isRemovable == true)
                    {
                        processos.RemoveAt(i);
                        qtdeProcessos--;
                    }
                }

                if (processos.Count == 0)
                {
                    isQuantum = true;
                }
                

            }
        }
    }
}