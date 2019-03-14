using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porcentaje
{
    public class RegladeRecargoService
    {

        
           
          
            public decimal Recargo(Comprobante.Comprobante comprobante)
            {
                decimal Recargo = 0;
                decimal iva = 0;
                
               var c = (comprobante.FechaVen - comprobante.FechaDePago).Days;



            if (c > 0 && c <= 15)
                {
                    iva = ((comprobante.Importe) * Convert.ToDecimal(0.005));
                    Console.WriteLine("tienes  de Pago ");
                }
                else if (c > 15 && c <= 30)
                {
                    iva = ((comprobante.Importe) * Convert.ToDecimal (0.015));
                    Console.WriteLine("tienes  de Pago");
                }
                else if  (c > 30 && c <= 60)
                {
                    iva = ((comprobante.Importe) * Convert.ToDecimal(0.030));
                    Console.WriteLine("Tiene  de Pago");
                }
                else if (c >= 60)
                {
                iva = ((comprobante.Importe) * Convert.ToDecimal(0.060));
                Console.WriteLine("Tiene  de Pago");
                 }
            else 
                {
                    iva = (comprobante.DatosClientes);
                    Console.WriteLine("No hay Iva");
                }
                
                Console.Clear();
                Console.WriteLine("Nombre" + (comprobante.DatosClientes));
                Console.WriteLine("Valor de la Factura: " + comprobante.Importe);
                
                Console.WriteLine("Interes : " + (iva));
                Console.WriteLine("Total: " + (comprobante.Importe + (iva)));
                Console.WriteLine();
                Console.ReadLine();
                return Recargo;
            }
                
       




            
                
            }
           
        }

        
   

