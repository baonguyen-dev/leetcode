
var solution = new Solution();

Console.WriteLine(solution.TopKFrequent(new int[] {3,0,1,0}, 1));

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dict = new Dictionary<int, int>();
        var array = new List<int>();
        var value = 0;
        for (int i = 0; i < nums.Length; i++) {

            if (!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], 0);
            }

            dict[nums[i]] += 1;
        }
        
        dict = dict.OrderByDescending(p => p.Value).ToDictionary(p => p.Key, p => p.Value);

        foreach(var val in dict) {
            value += 1;

            if (value > k) {
                break;
            }

            array.Add(val.Key);
        }

        return array.ToArray();
    }
}
