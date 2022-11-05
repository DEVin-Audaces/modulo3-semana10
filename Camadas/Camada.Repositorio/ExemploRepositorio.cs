
using Camada.Negocio;
using Camada.Negocio.Entity;

namespace Camada.Repositorio
{
    public class ExemploRepositorio : IExemploRepositorio
    {
        public void HelloWorldRepositorio()
        {
            throw new NotImplementedException();
        }

        public int Save(PizzaEntity pizzaEntity)
        {
            //ToDo: Salvar no Entity Framework os dados
            //Esta simulando ao salvar no EF
            return new Random().Next();
        }
    }
}