using Halloween.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Halloween.ViewModels
{
    public class Sorcieres_VM
    {
        public Sorciere Sorciere { get; set; }
        // TODO: Question 1
        [Display(Name ="NombrePotions")]
        public int? NbPotion { get; set; }
    }
}
