using System;

namespace PatronObservador
{
    public class Program
    {
        static void Main(string[] args)
        {
            PatronObservador.Observador.Observador observador = new PatronObservador.Observador.Observador();
            Cliente cliente = new Cliente(observador);
            cliente.CrearObjetos();
            cliente.Menu();

            Console.ReadKey();
        }   
        
      
    }
}
