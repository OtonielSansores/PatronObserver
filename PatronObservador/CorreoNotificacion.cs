using PatronObservador.Interfaces;
using System;

namespace PatronObservador
{
    public class CorreoNotificacion : ISuscriptor
    {
        public void update()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
