public class Node{
  public int currentMin {get; set;}
  public int value {get; set;}
  public Node(int min, int value){
    this.currentMin=min;
    this.value=value;
  }
}
public class MinStack {
public int min {get; set;}
public Stack<Node> stack {get;set;}
    public MinStack() {
       min = int.MaxValue;
       stack = new Stack<Node>();  
    }
    
    public void Push(int val) {
       if(val<min)
           min=val;
        Node node =new Node(min,val);
        stack.Push(node);

    }
    
    public void Pop() {
        if(!isEmpty()){ 
        stack.Pop();
        if(!isEmpty())
             min=stack.Peek().currentMin;
        else
            min = int.MaxValue;
         }  
    }
    
    public int Top() {
        if(!isEmpty()){  
           return stack.Peek().value;
        }
        return 0;
    }
    
    public int GetMin() {
        return min;
    }

    private bool isEmpty(){
     return stack.Count == 0;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */