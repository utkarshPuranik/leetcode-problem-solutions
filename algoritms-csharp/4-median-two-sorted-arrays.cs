using System.Collections.Generic;

public class MedianTwoSortedArraySolution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int num1Length = nums1.Length;
        int num2Length = nums2.Length;
        int i=0, j=0;
        var numStack = new Stack<int>();
        
        while(i + j <= (num1Length + num2Length) / 2)
        {
            if (i == num1Length && j < num2Length){
                numStack.Push(nums2[j]);
                j++;
            } else if (j == num2Length && i < num1Length){
                numStack.Push(nums1[i]);
                i++;
            } else if(nums1[i] < nums2[j]){
                numStack.Push(nums1[i]);
                i++;
            } else if(nums1[i] >= nums2[j]){
                numStack.Push(nums2[j]);
                j++;
            }
        }
                
        if((num1Length + num2Length) % 2 == 0)
        {
            return (numStack.Pop() + numStack.Pop()) / 2.0;
        } 
    
        return numStack.Pop();
    }
}