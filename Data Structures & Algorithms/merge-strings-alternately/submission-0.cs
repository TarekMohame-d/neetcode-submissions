public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1 = 0;
        int n2 = 0;
        var ans = "";

        while (n1 < word1.Length && n2 < word2.Length) {
            ans += word1[n1++];
            ans += word2[n2++];
        }

        while (n1 < word1.Length) {
            ans += word1[n1++];
        }

        while (n2 < word2.Length) {
            ans += word2[n2++];
        }

        return ans;
    }
}