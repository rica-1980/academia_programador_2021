using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEquipamentos
{
    public class Chamado
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public Equipamento Equipamento { get; set; }
    }
}
