using PatronObservador.Interfaces;
using System;

namespace PatronObservador
{
    public class InstalarVersion : ISuscriptor
    {
        public void update()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
