using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Tournois
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateDebut { get; set; }

  }
}
