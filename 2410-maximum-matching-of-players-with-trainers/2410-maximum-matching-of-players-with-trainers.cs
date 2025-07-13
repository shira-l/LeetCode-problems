public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
      int count=0;
      Array.Sort(players) ;
      Array.Sort(trainers) ;
      Array.Reverse(players);
      Array.Reverse(trainers);
for(int i=0,j=0;i<players.Length&&j<trainers.Length;) {
    if(players[i]<=trainers[j]){
        count++;
        j++;
    }
     i++;
    }
    return count;
    }
}