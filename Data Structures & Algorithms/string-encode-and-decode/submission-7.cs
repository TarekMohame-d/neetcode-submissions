public class Solution {
    public string Encode(IList<string> strs) {
        var encoded = "";

        foreach (var str in strs) {
            int length = str.Length;
            encoded += $"{length}#{str}";
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> ans = [];
        string length = "";

        for (int i = 0; i < s.Length; i++) {
            if (s[i] != '#') {
                length += s[i];
            } else {
                int l = int.Parse(length);
                ans.Add(s.Substring(i + 1, l));
                length = "";
                i += l;
            }
        }

        return ans;
    }
}
