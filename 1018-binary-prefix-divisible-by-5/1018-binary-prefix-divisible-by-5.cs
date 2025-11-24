public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        int n =0;
        var answer = new List<bool>();
        foreach(int num in nums){
            n=(n*2+num)%5;
            answer.Add(n==0);
        }
        return answer;
    }
}