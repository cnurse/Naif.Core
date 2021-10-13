using System.Collections.Generic;
using Naif.Core.Models;

namespace Naif.Core.Framework
{
    public static class MenuItemsExtensions
    {
        public static bool ContainsIsActive(this IList<MenuItem> items)
        {
            bool containsIsActive = false;
            foreach (var item in items)
            {
                if (item.IsActive)
                {
                    containsIsActive = true;
                    break;
                }
            }

            //Try next level
            if (!containsIsActive)
            {
                foreach (var item in items)
                {
                    if (item.Items.ContainsIsActive())
                    {
                        containsIsActive = true;
                    }
                }
            }

            return containsIsActive;
        }
    }
}
