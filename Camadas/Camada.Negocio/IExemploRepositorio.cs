using Camada.Negocio.Entity;

namespace Camada.Negocio
{
    public interface IExemploRepositorio
    {
        void HelloWorldRepositorio();

        int Save(PizzaEntity pizzaEntity);
    }
}