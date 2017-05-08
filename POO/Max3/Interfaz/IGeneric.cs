using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max3.Clases;

namespace Max3.Interfaz
{
    public interface IGeneric<T>
    {
        bool Insert(T x);
        T GetById(int id);
        bool Edit(T id);
        bool Delete(int id);

    }
}
