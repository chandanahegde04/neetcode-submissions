public class Solution {
    public int MaxProfit(int[] prices) {
        int mini=prices[0];
        int res=0;
        foreach(int price in prices){
            if(price-mini > res)
                res=price-mini;
            if(price<mini)
                mini=price;
        }
        return res;
    }
}
