using System;

namespace AlgoritmosEscalonamento
{
    class Program
    {
        static void Main(string[] args)
        {

            int tipoAlgoritmo = 0;
            bool tipoDisponivel = false;

            Console.WriteLine("Algoritmos de Escalonamento");
            Console.WriteLine("Escolha qual Algoritmo deseja utilizar:");
            Console.WriteLine("1 - First come, first served (FCFS)");
            Console.WriteLine("2 - Shortest Job First (SJF)");
            Console.WriteLine("3 - Algorítmo de Prioridades");
            Console.WriteLine("4 - Algorítmo Round Robin");
            Console.WriteLine("5 - Sair");
            while (tipoDisponivel == false)
            {
                try
                {
                    tipoAlgoritmo = Convert.ToInt32(Console.ReadLine());
                    tipoDisponivel = tipoAlgoritmo > 0 && tipoAlgoritmo < 6 ? true : false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Escolha uma opção válida");
                }

                if (tipoAlgoritmo < 1 || tipoAlgoritmo > 5)
                {
                    Console.WriteLine("Escolha uma opção válida");
                }
            }       

            switch (tipoAlgoritmo)
            {
                case 1:
                    FCFS.OrdenarFCFS();
                    break;
                case 2:
                    SJF.OrdenarSJF();
                    break;
                case 3:
                    Prioridades.OrdenarPrioridades();
                    break;
                case 4:
                    RoundRobin.OrdenarRoundRobin();
                    break;
                default:
                    Console.WriteLine("Encerrando o Programa...");
                    break;
            }

            Console.WriteLine("Encerrando Programa...");
        }
    }
}
