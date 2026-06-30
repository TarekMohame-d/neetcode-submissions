public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach (var c in s) {
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else {
                if (stack.Count == 0)
                    return false;

                var peek = stack.Peek();

                if (peek == '(' && c != ')')
                    return false;

                if (peek == '{' && c != '}')
                    return false;

                if (peek == '[' && c != ']')
                    return false;

                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}
