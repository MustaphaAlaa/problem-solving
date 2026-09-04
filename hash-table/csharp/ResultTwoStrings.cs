class ResultTwoStrings
{
    /*
     * Complete the 'twoStrings' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

    public static string twoStrings(string s1, string s2)
    {
        HashSet<char> set = new(s1);
        foreach(var c in s2)
        {
            if(set.Contains(c))
                return "YES";
        }
        return "NO";
    }
}
