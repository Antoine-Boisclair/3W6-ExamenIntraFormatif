using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class Joueur
    {
        [Key]
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Position { get; set; }

    }
}
