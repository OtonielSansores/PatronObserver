using PatronObservador.Interfaces;
using System;

namespace PatronObservador
{
    class Compilar : ISuscriptor
    {
        public void update()
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}
