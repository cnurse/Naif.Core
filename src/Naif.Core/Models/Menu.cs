using System.Collections.Generic;

namespace Naif.Core.Models
{
    public class Menu
    {
        public string CssClass { get; set; }
        public string IsActiveCssClass { get; set; }
        public IList<MenuItem> Items { get; set; }
    }
}