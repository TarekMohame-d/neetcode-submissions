public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (!map.ContainsKey(num))
                map[num] = 0;

            map[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in map) {
            if (buckets[pair.Value] == null)
                buckets[pair.Value] = [];

            buckets[pair.Value].Add(pair.Key);
        }

        List<int> answer = new();

        for (int i = buckets.Length - 1; i >= 0 && answer.Count < k; i--) {
            if (buckets[i] == null)
                continue;

            foreach (int num in buckets[i]) {
                answer.Add(num);

                if (answer.Count == k)
                    break;
            }
        }

        return answer.ToArray();
    }
}
