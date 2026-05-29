using System.ComponentModel.DataAnnotations;

namespace Segundo_App_BancoDados.Models
{
    public class Usuario
    {
        [Display(Name ="Código")]
        public int? IdUsu { get; set; }

        [Display(Name ="Nome Completo")]
        [Required(ErrorMessage ="Campo nome é obrigatorio")]
        public string nomeUsu { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Campo cargo é obrigatorio")]
        public string cargo { get; set; }

        [Display(Name ="Data Nascimento")]
        [Required(ErrorMessage = "Data nascimento é obrigatorio")]
        [DataType(DataType.DateTime)]
        public DateTime dataNasc { get; set; }
    }
}
