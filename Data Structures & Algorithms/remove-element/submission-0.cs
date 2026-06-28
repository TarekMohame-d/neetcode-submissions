public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int p1 = 0;
        int p2 = nums.Length - 1;
        while (p1 <= p2) {
            if (nums[p1] == val) {
                nums[p1] = nums[p2];
                p2--;
            } else {
                k++;
                p1++;
            }
        }
        return k;
    }
}