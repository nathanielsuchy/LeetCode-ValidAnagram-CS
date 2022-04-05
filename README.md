# LeetCode-ValidAnagram-CS
A solution for LeetCode "Valid Anagram" in C#

## Explanation
You have two possible solutions to solve this problem. You can either sort both strings and compare them or you can use a hash table to count each letter. I'm not good at sorting algorithms (which arguably take up more memory in the process when using algorithms like QuickSort or BubbleSort) so I decided to use a hash table (C# calls this a dictionary).

**Steps**

1. First you should compare the length of both strings. If they are not equal they cannot be anagrams and you're wasting compute resources creating HashMaps for this.
2. Next you should create a Dictionary where the key is a character and the value is an integer.
3. For each dictionary iterate over the string with a foreach loop. First check if the dictionary already contains the key. If the dictionary already contains the key just append the count by one, otherwise create the key with an initial value of one.
4. Compare the dictionaries. You can start with either the dictionary for string s or string t since they are the same length, if one letter is changed the values won't match and the loop will return false. If you start with sh for each key you'll check if th contains it. If it does not you can go ahead and return false. If it does contain it then check that the value is the same. If it is not the same return false. If the loop successfully completed without returning false then your string is an anagram.

**Stats**

Runtime: 104 ms, faster than 56.16% of C# online submissions for Valid Anagram.

Memory Usage: 38.1 MB, less than 98.94% of C# online submissions for Valid Anagram.

## Solution
```cs
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
```
