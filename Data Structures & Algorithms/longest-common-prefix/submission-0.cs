public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder res= new StringBuilder();
        int index=0;
        string temp=strs[0];
        for(int i=0;i<temp.Length;i++){
            foreach(string str in strs){
                if(i>=str.Length || str[i]!=temp[i])
                    return res.ToString();
            }
            res.Append(temp[i]);
        }
        return res.ToString();
    }
}