using System.Collections.Generic;

namespace Naif.Core.Models
{
    public abstract class BaseMenuItem
    {
        public IList<MenuItem> Items { get; set; }

    }
}