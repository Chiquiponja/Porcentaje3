using Porcentaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeIntereses
{
    class EjercicioComprobante
    {
       

        static void Main(string[] args)
        {

            Comprobante.Comprobante comp1 = new Comprobante.Comprobante();
            comp1.TipoDeComprobante = ("Factura A");
           
            
            comp1.FechaEm = new DateTime(2019, 2, 5);
            Console.WriteLine("INGRESE NOMBRE");
            comp1.DatosClientes = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("INGRESE LA FECHA DE PAGO");
            comp1.FechaVen = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("INGRESE LA FECHA DE VENCIMIENTO");

            comp1.FechaDePago = Convert.ToDateTime(Console.ReadLine());

            Console.Write("INGRESE EL IMPORTE DE LA FACTURA ");
            comp1.Importe = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("valor de comprobante es: " + comp1.Importe);

            var recargoService = new RegladeRecargoService();
            var recargoCobrar = recargoService.Recargo(comp1);




            Console.ReadKey();
        }

    }
}
