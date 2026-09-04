public class Solution_TwoSum
{
     public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        int[] result = new int[2];

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            int compliancy =  target - nums[i];
            if (dic.ContainsKey(compliancy) && dic[compliancy] != i)
            {
                result[0] = dic[compliancy];
                result[1] = i;
                return result;
            }
        }
        return result;
    }
}
