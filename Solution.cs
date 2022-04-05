public class Solution {
    public bool IsAnagram(string s, string t) {
        // If string lengths are not equal the strings cannot be anagrams
        if (s.Length != t.Length) return false;
        
        // Create a Dictionary to count the letters in each string
        var sh = new Dictionary<char, int>();
        var th = new Dictionary<char, int>();
        
        // Fill the Dictionaries for each string
        foreach (var c in s) {
            if (sh.ContainsKey(c)) {
                sh[c] += 1;
            } else {
                sh.Add(c, 1);
            }
        }
        
        foreach (var c in t) {
            if (th.ContainsKey(c)) {
                th[c] += 1;
            } else {
                th.Add(c, 1);
            }
        }
        
        // Compare the Dictionaries
        foreach (var item in sh) {
            if (th.ContainsKey(item.Key)) {
                if (!(item.Value == th[item.Key])) {
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
