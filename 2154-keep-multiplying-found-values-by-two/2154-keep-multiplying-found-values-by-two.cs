public class Solution {
    public int FindFinalValue(int[] nums, int original) {
      Array.Sort(nums); 
     foreach(int num in nums){
        if(num==original){
            original*=2;
        }
     }
    return original;
    }
}