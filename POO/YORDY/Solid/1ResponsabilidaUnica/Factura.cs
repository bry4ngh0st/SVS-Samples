using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YORDY.Solid
{
    public class Factura
    {
        public string Codigo;
        public DateTime FechaEmicion;
        public decimal ImporteFactura;
        public decimal ImportanteIVa;
        public decimal ImportanteDeducion;
        public decimal ImportanteTotal;
        public  ushort PorcentajeDeducion;


        public void CalcularTotal()
        {
            //no--ImportanteDeducion = (ImporteFactura * PorcentajeDeducion)/100;

            //calcualar la deducion
            Deduccion deducion = new Deduccion(PorcentajeDeducion);
            ImportanteDeducion = deducion.CalcualrDeducion(ImporteFactura);
            // Primer Principio calculamos IVA 
            IVA iva = new IVA();
            ImportanteIVa = iva.ClacualarIva(ImportanteIVa);

            // primer principio calculamos el total
            ImportanteTotal = (ImporteFactura- ImportanteDeducion )+ ImportanteIVa;
            Console.WriteLine(ImportanteTotal);

        }
    }
}
