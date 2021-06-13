using System;
using System.Collections.Generic;

public class PalindromeNumberSolution {
    public bool IsPalindrome(int x) {
        string input = Convert.ToString(x);
        if(input[0] == '-')
            return false;
        
        Stack<char> values = new Stack<char>();
        int startIndex = 0;
        
        for(int i = startIndex; i < input.Length; i++)
        {
            values.Push(input[i]);
        }
        List<char> outputList = new List<char>();
        while(values.Count > 0)
        {
            outputList.Add(values.Pop());
        }
        
        string returnValue = string.Join("", outputList.ToArray());
        return returnValue == input;
    }
}