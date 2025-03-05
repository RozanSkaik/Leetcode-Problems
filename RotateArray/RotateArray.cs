public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length; // check if k not larger than array length
        Array.Reverse(nums); // Reverse all array
        Array.Reverse(nums, 0 , k); // Reverse again first k number
        Array.Reverse(nums, k , nums.Length - k); // Reverse last number after k
    }
}
