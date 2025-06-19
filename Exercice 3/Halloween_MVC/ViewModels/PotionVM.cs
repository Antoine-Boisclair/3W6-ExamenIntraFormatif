using Halloween.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Halloween.ViewModels
{
    public class PotionVM
    {
        public Potion Potion { get; set; }
        public IEnumerable<SelectListItem> ListeSorcieres { get; set; }
    }
}
