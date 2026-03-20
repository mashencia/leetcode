//03.20.2026

/*
~ Valid Parentheses ~

Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool IsValid(string s) {
        if(s[0] == ')' || s[0] == ']' || s[0] == '}') return false;
        
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(' || s[i] == '[' || s[i] == '{'){
                stack.Push(s[i]);
            }else if(s[i] == ')' || s[i] == ']' || s[i] == '}'){
                if(stack.Count == 0){
                    return false;
                }else if(stack.Peek() == '(' && s[i] == ')'){
                    stack.Pop();
                }else if(stack.Peek() == '[' && s[i] == ']'){
                    stack.Pop();
                }else if(stack.Peek() == '{' && s[i] == '}'){
                    stack.Pop();
                }else{
                    return false;
                }
            }

            
        }
        if(stack.Count == 0)return true; 
        return false;
    }
}