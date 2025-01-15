public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsDic =  
                       new Dictionary<int, int>(); 

        for(int i = 0; i< nums.Length; i ++){
            int secondNumber = target - nums[i];
            try{
                return new int[] { numsDic[secondNumber], i };
            }
            catch
            {
                numsDic[nums[i]] = i;
            }
        }
        return new int[0];

        //Second way without using dictionaty:::
        // int[] result = [];
        // for(int i = 0; i < nums.Length; i++){
        //     for(int j = i+1; j< nums.Length; j++){
        //         if(nums[i] + nums[j] == target){
        //             result = new int[] {i,j};
        //         }
        //     }
        // }
        // return result;
    }
}
