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
    
    public partial class PedidoDetalle
    {
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> PedidoId { get; set; }
        public int Sincronizado { get; set; }
        public int IsDelete { get; set; }
        public int Compagnia { get; set; }
    }
}
