using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador
{
    public class EjecucionPruebasUnitarias : ISuscriptor
    {
        public void update()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
