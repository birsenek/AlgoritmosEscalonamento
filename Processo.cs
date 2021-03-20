using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmosEscalonamento
{
    public class Processo
    {
        public string nome { get; set; }
        public double tempoProcesso { get; set; }
        public double prioridadeProcesso { get; set; }
        public bool isRemovable { get; set; }
    }
}
