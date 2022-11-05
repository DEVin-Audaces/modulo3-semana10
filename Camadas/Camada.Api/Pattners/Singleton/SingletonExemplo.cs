using System.Runtime.CompilerServices;

namespace Camada.Api.Pattners.Singleton
{
    public sealed class SingletonExemplo
    {
        private static SingletonExemplo _intancia;
        public int AumentoSalario { get; }

        private SingletonExemplo()
        {
            AumentoSalario = 50;
        }

        static SingletonExemplo()
        {
            _intancia = new SingletonExemplo();
        }

        public static SingletonExemplo BuscarInstancia()
        {
            return _intancia;
        }
    }
}
