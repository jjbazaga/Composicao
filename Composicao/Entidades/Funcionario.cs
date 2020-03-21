using System.Collections.Generic;
using Composicao.Entidades.Enumerador;

namespace Composicao.Entidades
{
    class Funcionario
    {
        public string Nome { get; set; }
        public NivelTrabalho Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHoras> Contrato { get; set; } = new List<ContratoHoras>();
        public Funcionario()
        {
        }
        public Funcionario(string nome, NivelTrabalho nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AdicionarContrato(ContratoHoras contrato)
        {
            Contrato.Add(contrato);
        }
        public void RemoverContrato(ContratoHoras contrato)
        {
            Contrato.Remove(contrato);
        }
        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach(ContratoHoras obj in Contrato)
            {
                if(obj.Data.Year == ano && obj.Data.Month == mes)
                {
                    soma += obj.ValorTotal();
                }
            }
            return soma;
        }
    }
}