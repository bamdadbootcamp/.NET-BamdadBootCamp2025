using System.Runtime.CompilerServices;

namespace Common.CollectionExtensions;

public static class CollectionUtility
{
    public static void AddWithIgnoreDuplicate<T>(this List<T> list, T item)
    {
        if (!list.Contains(item))
            list.Add(item);
    }
}
