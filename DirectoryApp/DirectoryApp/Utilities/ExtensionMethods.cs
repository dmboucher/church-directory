using System.Collections.Generic;
using System.Linq;

namespace DirectoryApp
{
    public static class ExtensionMethods
    {
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self) => 
            self?.Select((item, index) => (item, index)) ?? new List<(T, int)>();
    }
}
