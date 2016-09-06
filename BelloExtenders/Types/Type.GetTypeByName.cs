using System;
using System.Linq;

namespace BelloExtenders.Types
{
    public static partial class ExtensionMethods
    {
        public static Type GetTypeByName(this Type type, string name, string @namespace = null)
        {
            // Get IEnumerable<Type> of all types in the domain that match the given name
            var ad = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => !a.IsDynamic)
                .SelectMany(a => a.GetTypes())
                .Where(t => t.Name.Equals(name));

            // If more than one type match the name given, return the type that is in the same namespace as the base type
            var enumerable = ad as Type[] ?? ad.ToArray();
            return enumerable.Count() > 1 ?
                enumerable.Where(t => t.IsClass && t.Namespace == (@namespace ?? type.Namespace)).FirstOrDefault(t => t.Name.Equals(name)) :
                enumerable.FirstOrDefault(t => t.Name.Equals(name));

            // Only one type matched the given name, so return it
        }
    }
}
