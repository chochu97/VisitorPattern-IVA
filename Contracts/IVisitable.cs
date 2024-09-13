using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorIVA.Contracts
{
    public interface IVisitable
    {
        double Aceptar(IVisitor visitor);
    }
}
