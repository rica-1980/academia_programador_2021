using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEquipamentos
{
    public class CRUDEquipamento
    {
        public void InsereEquipamento(List<Equipamento> equipamentos, Equipamento equipamento)
        {
            equipamentos.Add(equipamento);
        }

        public void RetornaEquipamentos(List<Equipamento> equipamentos)
        {
            foreach (var item in equipamentos)
            {
                Console.WriteLine($"Nome: {item.Nome} - Número de série: {item.NumeroSerie} - Fabricante: {item.Fabricante}");
            }
        }

        public void AtualizaEquipamento(Equipamento equipamento, string nome, string numeroSerie, string fabricante, double preco, DateTime dataFabricacao)
        {
            equipamento.Nome = nome;
            equipamento.NumeroSerie = numeroSerie;
            equipamento.Fabricante = fabricante;
            equipamento .Preco = preco;
            equipamento.DataFabricacao = dataFabricacao;
        }

        public void RemoveEquipamento(List<Equipamento> equipamentos, Equipamento equipamento)
        {
            equipamentos.Remove(equipamento);
        }
    }
}
