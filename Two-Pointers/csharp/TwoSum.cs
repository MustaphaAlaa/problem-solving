public class Solution_TwoSumII
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var right = numbers.Length-1;
        for (var left = 0; left < numbers.Length; )
        {
            if (numbers[left] + numbers[right] == target)
                return new int[2] { left + 1, right + 1 };
            else if (numbers[left] + numbers[right] > target)
                right--;
            else
                left++;
        }
        return new int[2];
    }
}
