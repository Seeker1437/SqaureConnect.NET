using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SquareConnect.Util
{
    internal static class ObjectHelper
    {
        private static readonly Type StringType = typeof(string);

        public static IEnumerable<KeyValuePair<string, string>> GetStringProperties(this object obj)
        {
            return from property in obj.GetType().GetTypeInfo().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                   where property.PropertyType == StringType
                   select new KeyValuePair<string, string>(property.Name, property.GetValue(obj, null) as string);
        }
    }
}
