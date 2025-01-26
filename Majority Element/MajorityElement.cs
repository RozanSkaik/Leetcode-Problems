public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> numsDic = new Dictionary<int, int>();
        int result = 0;
        foreach (int num in nums)
        {
            if (!numsDic.ContainsKey(num))
                numsDic.Add(num, 1); // the first time so add 1
            else
                numsDic[num] += 1; //another times...
            // check if max of values(times) = current value
            if (numsDic.Values.Max() == numsDic[num]) result = num; 
        }
        return result;
    }
}
