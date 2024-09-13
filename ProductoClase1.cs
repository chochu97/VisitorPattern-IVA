using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorIVA
{
    public class ProductoClase1 : Producto
    {
        public ProductoClase1(double precio) : base(precio)
        {
        }

        public override double Aceptar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
