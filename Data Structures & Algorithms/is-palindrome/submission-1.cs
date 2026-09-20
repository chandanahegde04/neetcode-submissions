public class Solution {
    public bool isValid(char ch){
        if((ch>='a' && ch<='z') ||
            (ch>='A' && ch<='Z') ||
            (ch>='0' && ch<='9')){
                return true;
            }
        return false;
    }
    public bool IsPalindrome(string s) {
        int start=0;
        int end=s.Length-1;
        while(start<end){
            while(start<end && !isValid(s[start]))
                start++;
            while(start<end && !isValid(s[end]))
                end--;
            if(char.ToLower(s[start])!=char.ToLower(s[end]))
                return false;
            start++;
            end--;
        }
        return true;
    }
}
