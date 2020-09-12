using System.Collections.Generic;

namespace Naif.Core.Tests.Common
{
    public class Util
    {
        public static List<int> CreateIntegerList(int count)
        {
            var list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}
