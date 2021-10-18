using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente deve ser informado.")]
        [MaxLength(100, ErrorMessage = "O nome do cliente pode conter até 100 caracteres.")]
        [MinLength(4, ErrorMessage = "O nome do cliente deve ser informado")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF do cliente deve ser informado.")]
        [MaxLength(15, ErrorMessage = "O CPF do cliente pode conter até 15 caracteres.")]
        [MinLength(11, ErrorMessage = "O CPF é inválido")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O telefone do cliente deve ser informado.")]
        [MaxLength(15, ErrorMessage = "O telefone do cliente pode conter até 15 caracteres.")]
        [MinLength(8, ErrorMessage = "O telefone é inválido")]
        public string Telefone { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O saldo do cliente não pode ser negativo.")]
        public decimal Saldo { get; set; } = 0;

        [Required(ErrorMessage = "A status deve ser informado.")]
        [ForeignKey("Status")]
        public int StatusId { get; set; }

        [JsonIgnore]
        public virtual Status Status { get; set; }

        [JsonIgnore]
        public virtual Oferta Oferta { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
