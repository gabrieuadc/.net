using System.ComponentModel.DataAnnotations;

namespace padrao.Models{
    public class CustoModel{

        public int id{get;set;}
        [Required]
        public String? cc{get;set;}
        [Required]
        public int mod{get;set;}
        [Required]
        public int md{get;set;}
        [Required]
        public int cif{get;set;}
        [Required]
        public int cpp{get;set;}
        [Required]
        public String? exercicio{get;set;}

    }

}