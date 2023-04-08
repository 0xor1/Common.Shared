namespace Common.Shared;

public static class IEnumerableExts
{
    public static IEnumerable<T> GetDuplicates<T>(this IEnumerable<T> strs) =>
        strs.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
}