public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder, (x, y) => x.Length.CompareTo(y.Length));
        bool isExist;
       IList<string> output=new List<string>();
       foreach(string f in folder) {
        isExist=false;
        foreach(string f2 in output){
            if(f.StartsWith(f2+"/"))
               {
                isExist=true;
                 break;
                 }
        }
           if(!isExist)
           output.Add(f);
       }
       return output;
    }
}