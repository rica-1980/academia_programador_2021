using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEquipamentos
{
    public class CRUDChamado
    {
        public void InsereChamdo(List<Chamado> chamados, Chamado chamado)
        {
            chamados.Add(chamado);
        }

        public void RetornaChamado(List<Chamado> chamados)
        {
            foreach (var item in chamados)
            {
                Console.WriteLine($"Chamado: {item.Titulo} - Descrição: {item.Descricao} - " +
                   $"Abertura chamado: {item.DataAbertura} - Equipamento: {item.Equipamento.Nome} - " +
                   $"Fabricante: {item.Equipamento.Fabricante}");
            }
        }

        public void AtualizaChamado(Chamado chamado, string nomeEquipamento, string titulo, string descricao, DateTime dataAbertura)
        {
            chamado.Titulo = titulo;
            chamado.Descricao = descricao;
            chamado.DataAbertura = dataAbertura;
            chamado.Equipamento.Nome = nomeEquipamento;
        }

        public void RemoveChamado(List<Chamado> chamados, Chamado chamado)
        {
            chamados.Remove(chamado);
        }
    }
}
