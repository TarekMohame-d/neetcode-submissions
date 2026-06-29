public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            int[] chars = new int[26];
            foreach (var c in str) {
                int i = c - 'a';
                chars[i]++;
            }

            string key = string.Join(",", chars);

            if (!map.ContainsKey(key))
                map[key] = [str];
            else
                map[key].Add(str);
        }

        return map.Values.ToList();
    }
}
