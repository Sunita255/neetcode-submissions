public class Solution {
    public bool IsPalindrome(string s) {
        bool isPalindrome = true;
        int left = 0, right = s.Length - 1;
        while(left < right)
        {
            if(!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;

            }
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        return isPalindrome;
    }
}
