using System;
using System.Collections.Generic;

public class ReverseIntegerSolution {
    public int Reverse(int x) {
        bool isNegative = false;
        string input = Convert.ToString(x);
        Stack<char> values = new Stack<char>();
        int startIndex = 0;
        if(input[0]=='-')
        {
            isNegative = true;
            startIndex = 1;
        }
        for(int i=startIndex; i<input.Length; i++)
        {
            values.Push(input[i]);
        }
        List<char> outputList = new List<char>();
        while(values.Count>0)
        {
            outputList.Add(values.Pop());
        }
        string returnValue = isNegative ? "-" + string.Join("", outputList.ToArray()) : string.Join("", outputList.ToArray());
        int returnInteger = 0;
        if(int.TryParse(returnValue, out returnInteger))
            return returnInteger;
        return returnInteger;
    }
}