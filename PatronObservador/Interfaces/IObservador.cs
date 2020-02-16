
using PatronObservador.Interfaces;

namespace PatronObservador
{
    public interface IObservador
    {
        void AgregarSuscriptor(ISuscriptor suscriptor);
        void RemoverSuscriptor(ISuscriptor suscriptor);
        void NotificarSuscriptores();
        void SubirCodigo();

    }
}
