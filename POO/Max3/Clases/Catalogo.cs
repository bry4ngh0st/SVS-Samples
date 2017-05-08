using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3.Clases
{
    public class Catalogo
    {
        public Catalogo()
        {
            var catalog = new AggregateCatalog();
            CompositionContainer _container;

            // catalog.Catalogs.Add(new DirectoryCatalog("."));
            catalog.Catalogs.Add(new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly()));
            _container = new CompositionContainer(catalog);

            _container.ComposeParts(this);
        }
    }
}
