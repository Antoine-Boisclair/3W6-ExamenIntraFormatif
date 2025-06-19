using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Halloween.Models
{
    public class Potion
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        [ForeignKey("Creatrice")]
        public int Sorciere_Id { get; set; }
        [ValidateNever]
        public Sorciere Creatrice { get; set; }
    }
}
