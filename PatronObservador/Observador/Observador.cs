using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;

namespace PatronObservador.Observador
{
    public class Observador : IObservador
    {
        List<ISuscriptor> suscriptores = new List<ISuscriptor>();
        public void AgregarSuscriptor(ISuscriptor suscriptor)
        {
            suscriptores.Add(suscriptor);
            Console.WriteLine("Se agrego el suscriptor");
        }

        public void RemoverSuscriptor(ISuscriptor suscriptor)
        {
            suscriptores.Remove(suscriptor);
        }

        public void NotificarSuscriptores()
        {
            foreach(ISuscriptor suscriptor in suscriptores)
            {
                suscriptor.update();
            }
        }
        public void SubirCodigo()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
            NotificarSuscriptores();
        }

    }
}
