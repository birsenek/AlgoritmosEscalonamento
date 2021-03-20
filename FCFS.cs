using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosEscalonamento
{
    class FCFS
    {
       public static void OrdenarFCFS()
        {
            int qtdeProcessos = 0;
            bool validarInteiro = false;

            Console.WriteLine("Você escolheu:");
            Console.WriteLine("1 - First come, first served (FCFS)");
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
            
            Console.WriteLine("Insira os nomes dos processos que serão analisados");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Processo _processo = new Processo();
                Console.WriteLine("\nProcesso {0}", i+1);
                _processo.nome = Console.ReadLine();
                processos.Add(_processo);
            }

            //ordenar processos
            //fcfs ou fifo os processos são listados por ordem de entrada
            Console.WriteLine("\nOrdem de Execução:\n");

            for (int i = 0; i < qtdeProcessos; i++)
            {
                Console.WriteLine("Processo {0}: {1}", i+1, processos[i].nome);
            }
        }
    }
}
