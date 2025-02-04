public class Solution {
    public int[] PlusOne(int[] digits) {
        string numStr = string.Join("", digits); // use to Join array elements
        
        BigInteger num = BigInteger.Parse(numStr) + 1; // use it for very large numbers 

        return num.ToString().Select(digit => Convert.ToInt32(digit.ToString())).ToArray(); //Return Convert large number to Array
    }
}
