public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> freq= new HashSet<int>();
        foreach(int num in nums){
            if(freq.Contains(num))
                return true;
            freq.Add(num);
        }
        return false;
    }
}