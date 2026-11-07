// Leetcode: 283. Move Zeroes

public class LC_MoveZeroes
{
    public int[] MoveZeroes2(int[] nums)
    {
        if (nums.Length < 2)
            return nums;

        int i = 0,
            nonzero = 0;

        while (i < nums.Length)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[nonzero]) = (nums[nonzero], nums[i]);
                nonzero++;
            }
            i++;
        }
        return nums;
    }


    public int[] MoveZeroes(int[] nums)
    {
        if (nums.Length < 2)
            return nums;
        

        for (int left = 0, right = 1; right < nums.Length; )
        {
            if (nums[left] != 0 && nums[right] != 0)
            {
                left++;
                right++;
            }
            else if (nums[left] == 0 && nums[right] != 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);

                left++;
                right++;
            }
            else if (nums[left] != 0 && nums[right] == 0)
            {
                left++;
                right++;
            }
            else if (nums[left] == 0 && nums[right] == 0)
            {
                right++;
            }
        }
        return nums;
    }
}
