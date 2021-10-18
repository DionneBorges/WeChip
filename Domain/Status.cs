using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Status
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição do status deve ser informada.")]
        [MaxLength(30, ErrorMessage = "A descrição do status pode conter até 30 caracteres.")]
        public string  Descricao { get; set; }

        public bool Finaliza { get; set; } = false;
        public bool Contabiliza { get; set; } = false;
    }
}
