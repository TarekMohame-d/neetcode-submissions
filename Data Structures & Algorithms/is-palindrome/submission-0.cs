public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int l = 0;
        int r = s.Length - 1;

        while (l < r) {
            if (!Char.IsLetterOrDigit(s[l])) {
                l++;
                continue;
            }
            if (!Char.IsLetterOrDigit(s[r])) {
                r--;
                continue;
            }

            if (s[l] != s[r])
                return false;

            l++;
            r--;
        }

        return true;
    }
}
