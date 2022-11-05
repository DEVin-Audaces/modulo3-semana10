using Camada.Negocio.Entity;

namespace Camada.Negocio.DTO
{
    public class PizzaDto
    {
        public string Descricao { get; set; }
        public decimal Valor => 50M;

        public static explicit operator PizzaEntity(PizzaDto pizzaDto)
        {
            return new PizzaEntity { Descricao = pizzaDto.Descricao, Valor = pizzaDto.Valor };
        }
    }
}
