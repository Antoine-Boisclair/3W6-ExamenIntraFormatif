using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Tournois
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15, MinimumLength =5)]
        public string Titre { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? DateDebut { get; set; }
        [ValidateNever]
        public List<Equipe>? Equipes { get; set; }

  }
}
