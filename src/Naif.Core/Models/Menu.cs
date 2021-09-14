// ReSharper disable UnusedType.Global
namespace Naif.Core.Models
{
    public class Menu : BaseMenuItem
    {
        public Menu()
        {
            Depth = 1;
        }
        
        public int Depth { get; set;}
        
        public string IsActiveCssClass { get; set; }
    }
}