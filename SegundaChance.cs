using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosEscalonamento
{
    class SegundaChance
    {
        public static void PaginarSegundaChance()
        {
            int qtdeProcessos = 0;
            bool validarInteiro = false;

            Console.WriteLine("Você escolheu:");
            Console.WriteLine("5 - Gerenciamento de Memória - Segunda Chance");
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

            Console.WriteLine("Insira os nomes dos processos que serão analisados e se foram executados recentemente.");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Processo _processo = new Processo();
                Console.WriteLine("\nProcesso {0}", i + 1);
                _processo.nome = Console.ReadLine();
                Console.WriteLine("\nO processo {0} foi utlizado recentement? S/N", _processo.nome);
                _processo.isRemovable = Console.ReadLine().Equals("S") ? false : true;
                processos.Add(_processo);
            }

            //ordenar processos
            //fcfs ou fifo os processos são listados por ordem de entrada
            Console.WriteLine("\nOrdem de Execução:\n");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Console.WriteLine("Processo {0}: {1} / Segunda Chance: {2}", i + 1, processos[i].nome, processos[i].isRemovable);
            }

            //remover de memória
            for (int i = 0; i < qtdeProcessos; i++)
            {
                if (processos[i].isRemovable == true)
                {
                    processos.RemoveAt(i);
                    qtdeProcessos--;
                }
            }

            //listar processos após gerenciamento
            Console.WriteLine("\nOrdem de Execução:\n");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Console.WriteLine("Processo {0}: {1} / Remover: {2}", i + 1, processos[i].nome, processos[i].isRemovable);
            }

        }
    }
}
