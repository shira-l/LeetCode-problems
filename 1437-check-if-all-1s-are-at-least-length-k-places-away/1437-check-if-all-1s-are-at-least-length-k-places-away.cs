public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        if(k==0)
           return true;
        int index = -2*k;
        for(int i =0;i<nums.Length;i++){
            if(nums[i]==1){
                if(i-index<k+1)
                  return false;
                index=i;
            }
        }
        return true;
    }
}