using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Presentation.Mvc.Models
{
    public class ProdutoCadastroModel
    {
        [Required(ErrorMessage = "Por favor informe o ID do produto")]
        public int IdProduto { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor informe o nome do produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor informe o preço do produto")]
        public double Preco { get; set; }
    }
}
