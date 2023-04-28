using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace padrao.Models{

    public class ServiceModel{


        [Key]
        public int id{get;set;}
        [Required]
        public int contact{get;set;}
        [Required]
        public String? name{get;set;}
        [Required]
        public String? service{get;set;}
        [Required]
        public int value{get;set;}
        [Required]
        public String? date{get;set;}


    }
}