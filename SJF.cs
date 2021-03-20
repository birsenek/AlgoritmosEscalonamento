using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosEscalonamento
{
    class SJF
    {
        public static void OrdenarSJF()
        {
            int qtdeProcessos = 0;
            bool validarInteiro = false;

            Console.WriteLine("Você escolheu:");
            Console.WriteLine("2 - Shortest Job First (SJF)");
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

            Console.WriteLine("Insira o nome e tempo médio de execução de cada processo que será analisado:");

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

            //ordenar processos
            //sjf os processos são ordenados por tempo de processamento crescente

            for (int i = 0; i < qtdeProcessos; i++)
            {
                for (int j = 0; j < qtdeProcessos; j++)
                {
                    if (processos[i].tempoProcesso < processos[j].tempoProcesso)
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
                Console.WriteLine("Processo {0}: {1}, Tempo de execução: {2}", i + 1, processos[i].nome, processos[i].tempoProcesso);
            }
        }
    }
}
