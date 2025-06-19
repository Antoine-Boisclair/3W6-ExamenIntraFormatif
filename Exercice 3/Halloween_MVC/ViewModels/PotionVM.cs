using Halloween.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Halloween.ViewModels
{
    public class PotionVM
    {
        public Potion Potion { get; set; }
        public SelectList ListeSorcieres { get; set; }
    }
}
