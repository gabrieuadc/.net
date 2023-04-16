using System.ComponentModel.DataAnnotations;

namespace padrao.Models
{
     public class UsuarioModel
    {
        public int Id{get;set;}
        [Required]
        public string? Nome{get;set;}
        [Required]
        public string? Email{get;set;}

    }

}