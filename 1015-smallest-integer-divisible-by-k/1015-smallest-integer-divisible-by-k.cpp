class Solution {
public:
    int smallestRepunitDivByK(int k) {
        int count = 1,n=1%k;
        if(k%2==0||k%5==0)
          return -1;
        while(n!=0){
            n=(n*10+1)%k;
            count++;
        }
        return count;
    }
};