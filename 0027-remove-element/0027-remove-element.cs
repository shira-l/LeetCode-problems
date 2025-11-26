public class Solution {
    public int RemoveElement(int[] nums, int val) {
     int index=nums.Length-1;
     for (int i = 0;i<=index;i++){
        while(nums[i]==val){
        if(index==-1)
              return 0;
        if(i==index)
          return index;
           nums[i]=nums[index];
           nums[index]=val;
           index--;
        }
     }
     return index + 1;  
    }
}