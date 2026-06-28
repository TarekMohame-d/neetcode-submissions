public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
            return "";

        int i = 0;

        while (i < strs[0].Length) {
            char c = strs[0][i];

            foreach (string s in strs) {
                if (i >= s.Length || s[i] != c)
                    return strs[0].Substring(0, i);
            }

            i++;
        }

        return strs[0];
    }
}