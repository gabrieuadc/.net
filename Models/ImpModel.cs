using System.ComponentModel.DataAnnotations;

namespace padrao.Models{
    public class ImpModels{

        public int Id{get;set;}


        [Required]
        public int rbruta{get;set;}
        [Required]
        public int pis{get;set;}
        [Required]
        public int cofins{get;set;}
        [Required]
        public string? exercicio{get;set;}

    }

}