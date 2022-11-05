using Camada.Negocio.DTO;
using Camada.Negocio.Entity;

namespace Camada.Negocio
{
    public class ExemploNegocio : IExemploNegocio
    {
        private readonly IExemploRepositorio exemploRepositorio;

        public ExemploNegocio(IExemploRepositorio exemploRepositorio)
        {
            this.exemploRepositorio = exemploRepositorio;
        }

        public void HelloWorldNegocio()
        {
            throw new NotImplementedException();
        }

        public int Save(PizzaDto dto)
        {
            PizzaEntity pizzaEntity = (PizzaEntity)dto;

            return exemploRepositorio.Save(pizzaEntity);
        }
    }
}