using System;
using System.Collections.Generic;

namespace ControleEquipamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando programa");

            List<Equipamento> listaEsquipamentos = new List<Equipamento>();
            CRUDEquipamento crudEquipamneto = new CRUDEquipamento();
            List<Chamado> listaChamados = new List<Chamado>();
            Chamado chamado = new Chamado();
            CRUDChamado crudChamado = new CRUDChamado();

            Equipamento equipamento1 = new Equipamento();
            equipamento1.Nome = "Serra Circular";
            equipamento1.NumeroSerie = "NPR3456";
            equipamento1.Preco = 900;
            equipamento1.Fabricante = "Maquita";
            equipamento1.DataFabricacao = DateTime.Now;

            Equipamento equipamento2 = new Equipamento();
            equipamento2.Nome = "Moto Serra";
            equipamento2.NumeroSerie = "CJY7765";
            equipamento2.Preco = 1200;
            equipamento2.Fabricante = "Tekena";
            equipamento2.DataFabricacao = DateTime.Now;


            crudEquipamneto.InsereEquipamento(listaEsquipamentos, equipamento1);
            crudEquipamneto.InsereEquipamento(listaEsquipamentos, equipamento2);
            crudEquipamneto.RetornaEquipamentos(listaEsquipamentos);
            Console.WriteLine();
            Console.WriteLine("Atualizando item 1");
            Console.WriteLine();
            crudEquipamneto.AtualizaEquipamento(equipamento1, "Cerrote", "LUG5678", "FULL", 450, new DateTime().AddDays(1));
            crudEquipamneto.RetornaEquipamentos(listaEsquipamentos);
            Console.WriteLine();
            Console.WriteLine("Remove item 2");
            Console.WriteLine();
            crudEquipamneto.RemoveEquipamento(listaEsquipamentos, equipamento2);
            crudEquipamneto.RetornaEquipamentos(listaEsquipamentos);

            chamado.Titulo = "Trocar disco";
            chamado.Descricao = "Realizar a trocar do disco quebrado";
            chamado.DataAbertura = DateTime.Now;
            chamado.Equipamento = equipamento1;

            crudChamado.InsereChamdo(listaChamados,chamado);
            crudChamado.RetornaChamado(listaChamados);
            crudChamado.AtualizaChamado(chamado, "Novo Equipamento do chamado", "Novo Titulo do chamado", "Nova descrição do chamado", DateTime.Now);
            crudChamado.RetornaChamado(listaChamados);
            crudChamado.RemoveChamado(listaChamados, chamado);
            crudChamado.RetornaChamado(listaChamados);
            Console.ReadKey();
        }
    }
}
