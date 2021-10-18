using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Oferta
    { 
        public int Id { get; set; }

        [MaxLength(10, ErrorMessage = "O CEP pode conter até 10 caracteres.")]
        public string CEP { get; set; }

        [MaxLength(100, ErrorMessage = "A rua pode conter até 100 caracteres.")]
        public string Rua { get; set; }

        [MaxLength(20, ErrorMessage = "O numero pode conter até 20 caracteres.")]
        public string Numero { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento pode conter até 50 caracteres.")]
        public string Complemento { get; set; }

        [MaxLength(50, ErrorMessage = "O Bairro pode conter até 50 caracteres.")]
        public string Bairro { get; set; }

        [MaxLength(50, ErrorMessage = "A cidade pode conter até 50 caracteres.")]
        public string Cidade { get; set; }

        [MaxLength(2, ErrorMessage = "O estado pode conter até 2 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "A cliente deve ser informado.")]
        [ForeignKey("Cliente")]
        public int? ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual IList<OfertaItem> OfertaItems { get; set; } = new List<OfertaItem>();

        public decimal Total { get; set; } = 0;

    }
}
