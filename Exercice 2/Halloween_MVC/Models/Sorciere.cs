using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Halloween.Models
{
    public class Sorciere
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Origine { get; set; }
        [ValidateNever]
        public List<Potion> Potions { get; set; }
    }
}
