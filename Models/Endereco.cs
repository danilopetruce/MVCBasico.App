using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.App.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Numero { get; set; }

        public String Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(8, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        public String Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(50, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public String Estado { get; set; }

        /*EF RELATIONS */

        public Fornecedor Fornecedor { get; set; }

    }
}
