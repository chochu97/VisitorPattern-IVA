using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorIVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto Banana = new ProductoClase1(2300);
            Producto Torta = new ProductoClase2(4500);

            IVisitor visitor = new IVA();

            

            Console.WriteLine("El precio ajustado a los impuestos de la Banana es: $" + Banana.Aceptar(visitor));
            Console.WriteLine("El precio ajustado a los impuestos de la Torta es: $" + Torta.Aceptar(visitor));
            Console.ReadKey();


        }
    }
}
