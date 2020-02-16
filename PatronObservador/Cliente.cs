using PatronObservador.Interfaces;
using System;

namespace PatronObservador
{
    public class Cliente
    {
        private readonly IObservador _observador;
        private ISuscriptor _compilar;
        private ISuscriptor _ejecucionPruebasUnitarias;
        private ISuscriptor _correoNotificacion;
        private ISuscriptor _instalarVersion;
        public Cliente(IObservador observador)
        {
            _observador = observador;
        }

        public void CrearObjetos()
        {
            _compilar = new Compilar();
            _ejecucionPruebasUnitarias = new EjecucionPruebasUnitarias();
            _correoNotificacion = new CorreoNotificacion();
            _instalarVersion = new InstalarVersion();
        }
        public void EjecutarPruebas(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    _observador.SubirCodigo();
                    break;
                case 2:
                    _observador.AgregarSuscriptor(_correoNotificacion);
                    Menu();
                    break;
                case 3:
                    _observador.AgregarSuscriptor(_compilar);
                    Menu();
                    break;
                case 4:
                    _observador.AgregarSuscriptor(_ejecucionPruebasUnitarias);
                    Menu();
                    break;
                case 5:
                    _observador.AgregarSuscriptor(_instalarVersion);
                    Menu();
                    break;
            }
        }
        public void Menu()
        {
            Console.WriteLine("Seleccione la opción");            

            Console.WriteLine("1 = Subir código");
            Console.WriteLine("2 = Agregar Notificador");
            Console.WriteLine("3 = Agregar Compilador");
            Console.WriteLine("4 = Agregar Ejecutor de Pruebas Unitarias");
            Console.WriteLine("5 = Agregar Instalador");

            int opcion = Convert.ToInt32(Console.ReadLine());

            EjecutarPruebas(opcion);
        }
    }
}
