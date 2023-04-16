using System.ComponentModel.DataAnnotations;

namespace padrao.Models{

    public class ServiceModel{

        public int id{get;set;}
        [Required]
        public int contact{get;set;}
        [Required]
        public String? name{get;set;}
        [Required]
        public String? service{get;set;}
        [Required]
        public String? value{get;set;}
        [Required]
        public String? date{get;set;}


    }
}