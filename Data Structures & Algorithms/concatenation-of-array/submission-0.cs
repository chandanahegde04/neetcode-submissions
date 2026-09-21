public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n=nums.Length*2;
        int m=nums.Length;
        int[] res= new int[n];
        for(int i=0;i<nums.Length;i++){
            res[i]=nums[i];
            res[m+i]=nums[i];
        }
        return res;
    }
}