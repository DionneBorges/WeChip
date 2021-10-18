using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Validador
    {
        private static IEnumerable<ValidationResult> ValidarObjeto(object obj)
        {
            var validacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);

            Validator.TryValidateObject(obj, contexto, validacao, true);

            return validacao;
        }

        public static void Validar(object obj)
        {
            var erros = ValidarObjeto(obj);
            var msg = "";
                
            foreach (var erro in erros)
                msg += erro.ErrorMessage + "\n";

            if (msg != "")
                throw new ArgumentException("Campo(s) inválido(s):\n" + msg);            
        }
    }
}
