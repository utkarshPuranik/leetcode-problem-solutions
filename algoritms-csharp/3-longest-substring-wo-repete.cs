using System.Collections.Generic;

public class LongestSubstringSolution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;
        int maxSize = 0;
        for(int i=0; i<s.Length; i++)
        {
            if(s.Length - i <= maxSize)
                return maxSize;
            int currentSize = 0;
            List<char> runningList = new List<char>();
            for(int j=i; j<s.Length; j++)
            {
                if(!runningList.Contains(s[j]))
                {
                    runningList.Add(s[j]);
                    currentSize += 1;
                }
                else
                    break;
            }
            if(currentSize > maxSize)
                maxSize = currentSize;
        }
        return maxSize;
    }
}