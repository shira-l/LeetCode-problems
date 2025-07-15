public class Solution {
    public int PossibleStringCount(string word) {
       int total = 0, count = 0;
 for (int i = 1; i < word.Length; i++)
 {
     if (word[i] == word[i - 1])
         count++;
     else if (count != 1)
     {
         total += count;
         count = 0;
     } 
 }
     total += count;
 return total+1;
    }
}