using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEquipamentos
{
    public class Equipamento
    {
        public string Nome { get; set; }
        public string NumeroSerie { get; set; }
        public string Fabricante { get; set; }
        public double Preco { get; set; }
        public DateTime DataFabricacao { get; set; }
    }
}
