using System.ComponentModel.DataAnnotations.Schema;

namespace Camada.Negocio.Entity
{
    [Table("Pizza")]
    public class PizzaEntity
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
