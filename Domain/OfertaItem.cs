using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain
{
    public class OfertaItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A oferta deve ser informado.")]
        [ForeignKey("Oferta")]
        public int? OfertaId { get; set; }

        [JsonIgnore]
        public virtual Oferta Oferta { get; set; }

        [Required(ErrorMessage = "O produto deve ser informado.")]
        [ForeignKey("Produto")]
        public int? ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }

    }
}
