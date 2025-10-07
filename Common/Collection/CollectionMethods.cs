using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Collection
{
    public static class CollectionMethods
    {
        public static string ToLineList<T>(this IEnumerable<T> objects, string prompt, string indent = "")
        {
            return string.Concat(prompt, ":\n", indent, string.Join(string.Format("\n{0}", indent), objects));
        }
    }
}
