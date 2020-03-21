using System;

namespace Composicao.Entidades
{
    class ContratoHoras
   {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Hora { get; set; }
        public ContratoHoras()
        {
        }
        public ContratoHoras(DateTime data, double valorPorHora, int hora)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Hora = hora;
        }
        public double ValorTotal()
        {
            return (Hora * ValorPorHora);
        }
    }
}