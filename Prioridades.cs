using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosEscalonamento
{
    class Prioridades
    {
        public static void OrdenarPrioridades()
        {
            int qtdeProcessos = 0;
            bool validarInteiro = false;

            Console.WriteLine("Você escolheu:");
            Console.WriteLine("3 - Algorítmo de Prioridades");
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

            Console.WriteLine("Insira o nome e a prioridade de execução de cada processo que será analisado:");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Processo _processo = new Processo();
                Console.WriteLine("\nNome do Processo:");
                _processo.nome = Console.ReadLine();
                Console.WriteLine("\nPrioridade do processo:");

                validarInteiro = false;
                while (validarInteiro == false)
                {
                    try
                    {
                        _processo.prioridadeProcesso = Convert.ToDouble(Console.ReadLine());
                        validarInteiro = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Insira um valor numérico.");
                    }
                }
               
                processos.Add(_processo);
            }

            //ordenar processos
            //os processos são ordenados por prioridade crescente

            for (int i = 0; i < qtdeProcessos; i++)
            {
                for (int j = 0; j < qtdeProcessos; j++)
                {
                    if (processos[i].prioridadeProcesso < processos[j].prioridadeProcesso)
                    {
                        Processo aux = new Processo();
                        aux = processos[i];
                        processos[i] = processos[j];
                        processos[j] = aux;
                    }
                }
            }

            //Listar processos
            Console.WriteLine("\nOrdem de Execução:\n");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Console.WriteLine("Processo {0}: {1}, Prioridade do processo: {2}", i + 1, processos[i].nome, processos[i].prioridadeProcesso);
            }
        }
    }
}
