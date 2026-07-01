public class Solution {
    public int FindDuplicate(int[] nums) {
        foreach (int num in nums) {
            int i = Math.Abs(num) - 1;

            if (nums[i] < 0)
                return Math.Abs(num);
            else
                nums[i] *= -1;
        }

        return -1;
    }
}
