using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VisitorIVA
{
    public class IVA : IVisitor
    {
        private double impuestoClase1 = 1.21d;
        private double impuestoClase2 = 1.105d;
        public double Visitar(ProductoClase1 prod)
        {
            return prod.Precio * impuestoClase1;
        }

        public double Visitar(ProductoClase2 prod)
        {
            return prod.Precio * impuestoClase2;
        }
    }
}
