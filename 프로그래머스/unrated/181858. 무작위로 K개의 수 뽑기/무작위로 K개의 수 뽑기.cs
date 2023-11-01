using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[] { };
        answer = Enumerable.Repeat(-1,k).ToArray();
        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!list.Contains(arr[i]))
            {
                if (list.Count >= k) break;
                list.Add(arr[i]);
            }
        }


        for (int i = 0; i < list.Count; i++)
        {
            answer[i] = list[i];
        }


        return answer;
    }
}