using Halloween.Models;
using System.Security.Policy;

namespace Halloween.ViewModels
{
    public class Sorcieres_VM
    {
        public Sorciere Sorciere { get; set; }
        public IEnumerable<Potion> ListePotions { get; set; }
        public int NombrePotions { get; set; } = 0;
    }
}
