using System.Numerics;

namespace Batch_1;
public class GroupAnagramChallenge
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var lookup = strs.ToLookup(key =>
        {
            var array = key.ToCharArray();
            Array.Sort(array);
            return array;
        }, new CharComparer());
        return lookup.Select(grouping => (IList<string>)grouping.ToList()).ToList();

        //--------------------------------------------------------------------------------
        var _lookup = strs.ToLookup(key =>
        {
            var array = key.ToCharArray();
            Array.Sort(array);
            return new string(array);
        });
        return lookup.Select(grouping => (IList<string>)grouping.ToList()).ToList();

        //------------------------------------------------------------------------------------
        
        return strs.GroupBy(x => string.Concat(x.OrderBy(c => c))).Select(x => (IList<string>)x.ToList()).ToList();

        //Dictionary<char[], List<string>> dict = new Dictionary<char[], List<string>>(new CharComparer());
        //foreach (var str in strs)
        //{
        //    var key = str.ToCharArray();
        //    Array.Sort(key);
        //    if (!dict.TryGetValue(key, out var temp))
        //    {
        //        temp = dict[key] = new List<string>();
        //    }
        //    temp.Add(str);
        //}

        //List<IList<string>> res = new List<IList<string>>(dict.Values.ToList());
        //return res;
    }

}  

public class CharComparer : IEqualityComparer<char[]>
{
    public bool Equals(char[] x, char[] y)
    {
        if (x == null || y == null)
        {
            return false;
        }

        if (x.Length != y.Length)
        {
            return false;
        }

        return x.SequenceEqual(y);
    }
    //public bool Equals(char[] x, char[] y)
    //{
    //    if (x == null || y == null)
    //    {
    //        return false;
    //    }

    //    if (x.Length != y.Length)
    //    {
    //        return false;
    //    }

    //    for (int i = 0; i < x.Length; i++)
    //    {
    //        if (x[i] != y[i])
    //        {
    //            return false;
    //        }
    //    }

    //    return true;
    //}

    public int GetHashCode(char[] obj)
    {
        return 0;
    }
}

