public class Solution {
    public int SmallestNumber(int n) {
        double log2 = Math.Log(n, 2);
        int pow=(int)log2+1;
        int result =(int) Math.Pow(2, pow);
        return result-1;       
    }
}