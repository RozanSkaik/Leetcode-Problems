public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length - 1; i >=0; i --){
            if(digits[i] < 9){
                digits[i]++; // icrease last number
                return digits;
            } 
            digits[i] = 0;
        }
        int[] newDigits = new int[digits.Length + 1]; // icrease array Lenght if digit > 9
        newDigits[0] = 1; // put first index = 1
        return newDigits;
    }
}
