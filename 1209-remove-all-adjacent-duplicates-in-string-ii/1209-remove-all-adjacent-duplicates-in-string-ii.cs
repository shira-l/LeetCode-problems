public class Node{
    public char value {get;set;}
    public int count {get;set;}
    public Node(char v,int c){
        value=v;
        count=c;
    }
}
public class Solution {
    public string RemoveDuplicates(string s, int k) {
      Stack<Node> stack = new Stack<Node>();
      Node node;
      foreach(char c in s){
        if(stack.Count!=0){
            node=stack.Peek();
            if(node.value==c){
                if(node.count==k-1){
                 for(int i=0;i<k-1;i++){
                stack.Pop();}
                 }
                 else
                    stack.Push(new Node(c,node.count+1));
                 }
            else
               stack.Push(new Node(c,1));
           }
        else
          stack.Push(new Node(c,1));
      }
     string result = new string(stack.Reverse().Select(node => node.value).ToArray());
      return result;
    }
}