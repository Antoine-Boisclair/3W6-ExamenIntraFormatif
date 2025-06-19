using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class Joueur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string Position { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }
        public FicheOfficielle? FicheOfficielle { get; set; }

    }
}
