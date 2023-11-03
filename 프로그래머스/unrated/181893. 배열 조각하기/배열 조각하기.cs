using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int[] answer = new int[] {};

        for (int i = 0; i < query.Length; i++)
        {
            
            if(i%2 == 0)
            {
                arr = arr.Take(query[i] + 1).ToArray();
            }
            else
            {
                arr = arr.Skip(query[i]).ToArray();
            }
        }

        answer = arr;

        return answer;
    }
}