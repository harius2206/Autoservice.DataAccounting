using System.Collections.Generic;
using System.Linq; 
using System.Text;

namespace Common.Interfaces.Extensions
{
    public static class KeyablesMethods
    {
        public static string ToKeyList(this IEnumerable<IKeyable> objects, string prompt)
        {
            return string.Format("{0}:\n\t{1}", prompt, string.Join("\n\t", objects.Select(e => e.Key)));
        }

        public static string ToKeyLine(this IEnumerable<IKeyable> objects, string prompt)
        {
            return string.Format("{0}:\t {1}", prompt, string.Join(", ", objects.Select(e => e.Key)));
        }

        public static string ToKeysHierarchy<T>(this T obj) where T : IHierarchical<T>
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(obj.Key);
            T parent = obj.Parent;
            while (parent != null)
            {
                sb.AppendFormat(" -> {0}", parent.Key);
                parent = parent.Parent;
            }
            return sb.ToString();
        }
    }
}