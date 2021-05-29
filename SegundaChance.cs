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
            Console.WriteLine("Qual a quantidade de páginas disponíveis?");

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
                _processo.isRemovable = Console.ReadLine().ToLower().Equals("s") ? false : true;
                processos.Add(_processo);
            }

            //ordenar processos
            //fcfs ou fifo os processos são listados por ordem de entrada
            Console.WriteLine("\nOrdem de Paginação:\n");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Console.WriteLine("Processo {0}: {1} / Remover: {2}", i + 1, processos[i].nome, processos[i].isRemovable);
            }

            var novosProcessos = new List<Processo> { };

            foreach (var processo in processos)
            {
                if (processo.isRemovable == false)
                    novosProcessos.Add(processo);
            }

            //listar processos após gerenciamento
            Console.WriteLine("\nOrdem de Paginação:\n");

            for (int i = 0; i < novosProcessos.Count; i++)
            {
                Console.WriteLine("Processo {0}: {1} / Remover: {2}", i + 1, novosProcessos[i].nome, novosProcessos[i].isRemovable);
            }

        }
    }
}
