using Camada.Negocio.DTO;

namespace Camada.Negocio
{
    public interface IExemploNegocio
    {
        void HelloWorldNegocio();
        int Save(PizzaDto dto);
    }
}