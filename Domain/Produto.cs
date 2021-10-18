using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Produto
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição do produto deve ser informada.")]
        [MaxLength(30, ErrorMessage = "A descrição do produto pode conter até 30 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A valor do produto deve ser informada.")]
        [Range(0.1, int.MaxValue, ErrorMessage = "O valor do produto não pode ser negativo ou igual a zero.")]
        public decimal Preco { get; set; }

        public Tipo tipo { get; set; }
    }
}
