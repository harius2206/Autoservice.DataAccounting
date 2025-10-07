using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Selection
{
    public static class KeyableMethods
    {
        public static string GetKey(dynamic obj)
        {
            return obj.Key;
        }

        public static T GetByKey<T>(this List<T> objects, string key) where T : class
        {
            for (int i = 0; i < objects.Count; i++)
            {
                if (GetKey(objects[i]) == key)
                    return objects[i];
            }
            return null;
        }

        public static string[] GetKeys<T>(this List<T> objects) {
                string[] names = new string[objects.Count];
                for (int i = 0; i < objects.Count; i++) {
                    names[i] = GetKey(objects[i]);
                }
                return names;
            }
    }
}
