public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var countS = new Dictionary<char, int>();

        foreach(var c in s){
            countS[c] = countS.GetValueOrDefault(c, 0) + 1;
        }

        foreach(var c in t){
            if(!countS.ContainsKey(c) || countS[c] == 0){
                return false;
            }

            countS[c]--;
        }

        return true;
    }
}

// Time Complexity -> O(n)
// Space Complexity -> O(n)
