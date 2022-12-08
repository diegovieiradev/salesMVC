using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Quantia { get; set; }
        public StatusVendas Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {
        }
        public RegistroVendas(int id, DateTime date, double quantia, StatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
