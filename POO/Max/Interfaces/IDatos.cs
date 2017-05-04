using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.Interfaces
{
    public interface IDatos<T>
    {
        bool Guardar(T p);
    }
}
