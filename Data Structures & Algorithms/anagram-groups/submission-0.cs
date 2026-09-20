public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var temp = new Dictionary<string, List<string>>();
        foreach(var item in strs)
        {
            char[] charArray = item.ToCharArray();
            Array.Sort(charArray);
            var sortedString = new string(charArray);
            if(!temp.ContainsKey(sortedString))
            {
                temp[sortedString] = new List<string>();
            }
            temp[sortedString].Add(item);
        }
        return temp.Values.ToList<List<string>>();
        
    }
}
