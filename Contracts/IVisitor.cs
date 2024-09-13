using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorIVA
{
    public interface IVisitor
    {
        double Visitar(ProductoClase1 prod);
        double Visitar(ProductoClase2 prod);
    }
}
