using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {



        static void Main(string[] args)
        {
            IFirebaseConfig confi = new FirebaseConfig()
            {
                AuthSecret = "ryja3YG6bf0hAcJNXVpvUDdY66j0LiBFtfvRKMKK",
                BasePath = "https://sigaapp-127c4-default-rtdb.firebaseio.com/"

            };



            IFirebaseClient client;
            //SincronizarPagos(confi);
            SincronizarPagoDetalle(confi);
            //SincronizarPedidoDetalle(confi);
            //SincronizarPedidos(confi);

            //SincronizarOrdenesDePagos(confi);

            //Console.WriteLine("Sincronizando Clientes");
            //SincronizarCLientes(confi);

            //Console.WriteLine("Sincronizando Factura");

            //SincronizarFacturas(confi);



            //Console.WriteLine("Sincronizando Clientes");
            //SincronizarCLientes(confi);

            //Console.WriteLine("Sincronizando Orden de Producto");
            //SincronizarProductos(confi);

            //Console.WriteLine("Sincronizando Facturas");
            //SincronizarCLientes(confi);

            //Console.WriteLine("Sincronizando Orden de Producto");
            //SincronizarProductos(confi);





            //SincronizarProductos(confi);
        }

        private static void SincronizarPagoDetalle(IFirebaseConfig confi)
        {
            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var detalles = from a in context.PagoDetallle
                          where a.Sincronizado == 0
                          select a;

            foreach (PagoDetallle detalle in detalles)
            {
                client.Set("PagoDetallle/" + detalle.Id, detalle);
                Console.WriteLine(detalle.Id);
            }

            Console.WriteLine();

        }

        private static void SincronizarPedidos(IFirebaseConfig confi)
        {
            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var pedidos = from a in context.Pedidos
                          where a.Sincronizado == 0
                          select a;

            foreach (Pedidos pedido in pedidos)
            {
                client.Set("Pedidos/" + pedido.Id, pedido);
                Console.WriteLine(pedido.Id);
            }

            Console.WriteLine();

        }


        private static void SincronizarPedidoDetalle(IFirebaseConfig confi)
        {
            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var detalles = from a in context.PedidoDetalle
                           where a.Sincronizado == 0
                           select a;

            foreach (PedidoDetalle pedido in detalles)
            {
                client.Set("PedidoDetalle/" + pedido.Id, pedido);
                Console.WriteLine(pedido.Id);
            }

            Console.WriteLine();

        }



        private static void SincronizarProductos(IFirebaseConfig confi)
        {
            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var productos = from a in context.Producto
                            where a.Sincronizado == 0
                            select a;

            foreach (Producto producto in productos)
            {
                client.Set("Productos/" + producto.Id, producto);
                Console.WriteLine(producto.Id);
            }

            Console.WriteLine();

        }
        //  private static void SincronizarProductos(IFirebaseConfig confi)
        //  {
        //      SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

        //      IFirebaseClient client = new FireSharp.FirebaseClient(confi);
        //      if (client != null)
        //      {
        //          Console.WriteLine("connection esta estabilizada");
        //      }
        //      var productoLista = from a in context.Producto
        //                      //where a.Sincronizado != "S"
        //                      select a;



        //      foreach (Producto producto in productoLista)
        //      {
        //          client.Set("Productos/" + producto.Id, producto);


        //          //actualizarProducto(producto.ProductoCodigo);
        //          Console.WriteLine(producto.Nombre);


        //      }

        //      Console.WriteLine();
        //      Console.ReadLine();


        //  }
        //static void actualizarProducto(string ProductoCodigo)
        //  { 
        //      using(var context = new SigaAppDB03Entities2())
        //      {
        //          var entity = context.Producto.FirstOrDefault(item => item.ProductoCodigo ==  ProductoCodigo);

        //          entity.Sincronizado = "S";
        //          context.SaveChanges();
        //      }



        //  }


        private static void SincronizarCLientes(IFirebaseConfig confi)
        {

            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var customers = from a in context.Cliente
                            where a.sincronizado != "S"
                            select a;

            foreach (Cliente customer in customers)
            {
                client.Set("Clientes/" + customer.codigo, customer);
                Console.WriteLine(customer.nombre);
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        private static void SincronizarFacturas(IFirebaseConfig confi)
        {
            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();
            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }

            var facturas = from a in context.Factura
                           where a.Sincronizado == 0
                           select a;

            foreach (Factura factura in facturas)
            {
                client.Set("Factura/" + factura.FacturaId, factura);
                Console.WriteLine(factura.FacturaId);

            }
            Console.WriteLine("Sincronizado");
        }



        //    var facturas = from a in context.Factura
        //                       //where a.Sincronizado != "S"
        //                       //where a.sincronizado != "S"
        //                   select a;

        //    foreach (Factura factura in facturas)
        //    {
        //        client.Set("Factura/" + factura.FacturaId, factura);
        //        Console.WriteLine(factura.FacturaId);


        //        //var entity = context.Factura.FirstOrDefault(item => item.FacturaId == factura.FacturaId);
        //        //entity.Sincronizado = "S";
        //        //context.SaveChanges();


        //    }

        //    Console.WriteLine("Sincronizado");

        //}
        private static void SincronizarDetalleFacturas(IFirebaseConfig confi)
        {

            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var facturas = from a in context.DetalleFactura
                           where a.Sincronizado == 0
                           //where a.Sincronizado != "S"
                           select a;

            foreach (DetalleFactura detalle in facturas)
            {
                client.Set("FacturaDetalles/" + detalle.FacturaId, detalle);
                Console.WriteLine(detalle.ID);


                //var entity = context.FaturaDetalle.FirstOrDefault(item => item.FacturaNumero == detalle.FacturaNumero);
                //entity.Sincronizado = "S";
                //context.SaveChanges();

            }

            Console.WriteLine("Sincronizado");

        }
 
        
    

        private static void SincronizarPagos(IFirebaseConfig confi)
        {

            SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

            IFirebaseClient client = new FireSharp.FirebaseClient(confi);
            if (client != null)
            {
                Console.WriteLine("connection esta estabilizada");
            }
            var Pagos = from a in context.Pago
                           where a.Sincronizado == 0
                           //where a.Sincronizado != "S"
                           select a;

            foreach (Pago pago in Pagos)
            {
                client.Set("Pago/" + pago.ID, pago);
                Console.WriteLine(pago.ID);


                //var entity = context.FaturaDetalle.FirstOrDefault(item => item.FacturaNumero == detalle.FacturaNumero);
                //entity.Sincronizado = "S";
                //context.SaveChanges();

            }

            Console.WriteLine("Sincronizado Pago");

        }


        //  private static void SincronizarOrdenesDePagos(IFirebaseConfig confi)
        //  {

        //      SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

        //      IFirebaseClient client = new FireSharp.FirebaseClient(confi);
        //      if (client != null)
        //      {
        //          Console.WriteLine("connection esta estabilizada");
        //      }
        //      var OrdenPago = from a in context.OrdenesDePago
        //                         //where a.Sincronizado != "S"
        //                     select a;

        //      foreach (OrdenesDePago detalle in OrdenPago)
        //      {
        //          client.Set("OrdenesDePago/" + detalle.Id, detalle);
        //          Console.WriteLine(detalle.Id);


        //          //var entity = context.FaturaDetalle.FirstOrDefault(item => item.FacturaNumero == detalle.FacturaNumero);
        //          //entity.Sincronizado = "S";
        //          //context.SaveChanges();

        //      }

        //      Console.WriteLine("Sincronizado");

        //  }
        //  private static void SincronizarDetallePagos(IFirebaseConfig confi)
        //  {

        //      SigaAppDB03Entities2 context = new SigaAppDB03Entities2();

        //      IFirebaseClient client = new FireSharp.FirebaseClient(confi);
        //      if (client != null)
        //      {
        //          Console.WriteLine("connection esta estabilizada");
        //      }
        //      var facturas = from a in context.DetalleFactura
        //                         //where a.Sincronizado != "S"
        //                     select a;

        //      foreach (DetalleFactura detalle in facturas)
        //      {
        //          client.Set("FacturaDetalle/" + detalle.FacturaNumero, facturas);
        //          Console.WriteLine(detalle.FacturaNumero);


        //          //var entity = context.FaturaDetalle.FirstOrDefault(item => item.FacturaNumero == detalle.FacturaNumero);
        //          //entity.Sincronizado = "S";
        //          //context.SaveChanges();

        //      }

        //      Console.WriteLine("Sincronizado");

        //  }

    }
}
