class Result_RansomNote
{
    /*
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        var dic = new Dictionary<string, int>();

        foreach (var word in magazine)
        {
            if (dic.ContainsKey(word))
                dic[word] += 1;
            else
                dic[word] = 1;
        }

        foreach (var word in note)
        {
            if (dic.ContainsKey(word) && dic[word] <= 1)
                dic[word] -= 1;
            else
            {
                System.Console.WriteLine("NO");
                return;
            }
        }
    }
}


