//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int Id { get; set; }
        public string FacturaId { get; set; }
        public string PedidoId { get; set; }
        public string clienteId { get; set; }
        public string clienteNombre { get; set; }
        public string FacturaFecha { get; set; }
        public string FacturaVencimiento { get; set; }
        public string MetodoDePago { get; set; }
        public Nullable<decimal> MontoFactura { get; set; }
        public Nullable<decimal> totalPagado { get; set; }
        public decimal MontoPendiente { get; set; }
        public int Sincronizado { get; set; }
        public int IsDelete { get; set; }
        public int Compagnia { get; set; }
        public string vendedorId { get; set; }
    }
}