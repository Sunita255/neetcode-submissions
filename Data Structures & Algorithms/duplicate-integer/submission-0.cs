public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool isDuplicate = false;
        Dictionary<int, int> duplicateNumDict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(duplicateNumDict.ContainsKey(nums[i]))
            {
               isDuplicate = true;
               break;
            }
            else
            {
              duplicateNumDict[nums[i]] = nums[i];
            }
        }
        return isDuplicate;
    }
}