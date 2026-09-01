public class TripletSum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // List<List<int>> lists = new();
        var lists = new int[nums.Length][3]();
        nums.Sort();

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            if (nums[i] > 0)
                break;

            var res = Sum(nums, i + 1, -1 * nums[i]);

            foreach (var list in res)
            {
                list.Add(nums[i]);
                lists.Add(list);
            }
        }

        return lists.ToArray();
    }

    public List<List<int>> Sum(int[] lst, int start, int target)
    {
        List<List<int>> resList = new();

        int left = start,
            right = lst.Length - 1;
        while (left < right)
        {
            if (lst[left] + lst[right] == target)
            {
                resList.Add(new List<int> { lst[left], lst[right] });
                left++;
                right--;
                while (left < right && lst[left] == lst[left + 1])
                    left++;
                while (left < right && lst[right] == lst[right - 1])
                    right--;
            }
            else if (lst[left] + lst[right] > target)
                right--;
            else
                left++;
        }
        return resList;
    }
}
