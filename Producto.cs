using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorIVA.Contracts;

namespace VisitorIVA
{
    public abstract class Producto : IVisitable
    {
        public double Precio {  get; set; }

        public Producto(double precio)
        {
            Precio = precio;
        }
        public abstract double Aceptar(IVisitor visitor);
        
    }
}
