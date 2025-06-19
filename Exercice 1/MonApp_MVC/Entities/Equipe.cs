using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Equipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Proprietaire { get; set; }
        [ValidateNever]
        public List<Tournois>? Tournois { get; set; }
        [ValidateNever]
        public List<Joueur>? Joueurs { get; set; }

     }
}
