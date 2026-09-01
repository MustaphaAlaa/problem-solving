//brute force
export function pair_sum_sorted_brute_force(nums: number[], target: number) {
  for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j < nums.length; j++) {
      if (nums[i] + nums[j] === target) {
        return [i, j];
      }
    }
  }
  return [];
}

//Two-Pointer

export const pair_sum_sorted = (nums: number[], target: number) => {
  let leftPointer = 0;
  let rightPointer = nums.length - 1;
  while (leftPointer < rightPointer) {
    let sum = nums[leftPointer] + nums[rightPointer];

    if (sum == target) return [leftPointer, rightPointer];
    else if (sum > target) {
      rightPointer--;
    } else {
      leftPointer++;
    }
  }
  return [];
};

let arr = pair_sum_sorted([-5, -2, 3, 4, 6], 7);
//test cases
arr = pair_sum_sorted([], 7);
arr = pair_sum_sorted([3], 7);
arr = pair_sum_sorted([3, 44], 7);
arr = pair_sum_sorted([3, 4], 7);
arr = pair_sum_sorted([3,3, 4], 7);
arr = pair_sum_sorted([-3,-3, 10], 7);
arr = pair_sum_sorted([-3,-3, -4], -7);
console.log(arr);
