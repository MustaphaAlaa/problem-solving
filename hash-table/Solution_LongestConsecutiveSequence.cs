public class Solution_LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        var longestChain = 0;

        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
                dic[nums[i]] = 0;
        }

        foreach (var kvp in dic)
        {
            if (!dic.ContainsKey(kvp.Key - 1))
            {
                var currentNumber = kvp.Key;
                var currentChain = 0;

                while (dic.ContainsKey(currentNumber))
                {
                    currentChain++;
                    currentNumber++;
                }
                longestChain = int.Max(longestChain, currentChain);
            }
        }

        return longestChain;
    }
}
