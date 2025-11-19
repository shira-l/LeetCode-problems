public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int i=0;
        for(;i<bits.Length-1;i++){
            if(bits[i]==1)
               i++;
        }
        if(i==bits.Length-1)
           return true;
        return false;
    }
}