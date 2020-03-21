using System;
using System.Globalization;
using Composicao.Entidades;
using Composicao.Entidades.Enumerador;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string nomedep = Console.ReadLine();
            Console.WriteLine("DADOS DO FUNCIONÁRIO E SEUS CONTRATOS: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível (Junior/Medio/Senior): ");
            NivelTrabalho nivel = Enum.Parse<NivelTrabalho>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departamento departamento = new Departamento(nomedep);
            Funcionario funcionario = new Funcionario(nome, nivel, salario, departamento);
            Console.WriteLine();
            Console.Write("Quantos são os contratos de trabalho? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Entre com contrato nº " + (i+1));
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Horas Trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                ContratoHoras Contrato = new ContratoHoras(data, valorhora, horas);
                funcionario.AdicionarContrato(Contrato);
                Console.WriteLine();
            }
            Console.Write("Entre o mês e o ano, para cálculo da Renda (mm/aaaa): ");
            string dataCalculo = Console.ReadLine();
            int ano = int.Parse(dataCalculo.Substring(3));
            int mes = int.Parse(dataCalculo.Substring(0, 2));
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento.Nome);
            Console.WriteLine("Renda até " + dataCalculo + ": " + funcionario.Renda(ano,mes).ToString("f2",CultureInfo.InvariantCulture));
        }                 
    }
}
