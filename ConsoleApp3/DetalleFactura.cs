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
    
    public partial class DetalleFactura
    {
        public int ID { get; set; }
        public string FacturaId { get; set; }
        public Nullable<decimal> LineaNumero { get; set; }
        public string ProductoCodigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<decimal> montoLinea { get; set; }
        public int Sincronizado { get; set; }
        public int IsDelete { get; set; }
        public int Compagnia { get; set; }
    }
}