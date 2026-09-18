public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach(var temp in s)
        {
            if(charCount.ContainsKey(temp))
            {
                charCount[temp]++;
            }
            else
            {
                charCount[temp] = 1; 
            }
        }
        foreach(var temp in t)
        {
            if(!charCount.ContainsKey(temp))
            {
                return false;
            }
            charCount[temp]--;
            if(charCount[temp] < 0)
            {
                return false;
            }
        }
        return true;
    }
}
