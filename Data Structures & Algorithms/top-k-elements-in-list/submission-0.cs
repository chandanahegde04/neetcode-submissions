public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq= new Dictionary<int,int>();
        foreach(int num in nums){
            if(freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num]=1;
        }
        int[] res= new int[k];
        int index=0;
        foreach(var item in freq.OrderByDescending(x=>x.Value)){
            res[index++]=item.Key;
            k--;
            if(k==0)
                return res;
        }
        return res;
    }
}
