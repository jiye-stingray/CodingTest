using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
     public int solution(int[,] lines)
    {
        int answer = 0;

        int[] ins = new int[200];

        int start = 0;
        int end = 0;

        for (int i = 0; i < lines.GetLength(0); i++)
        {
            start = lines[i, 0];
            end = lines[i, 1];

            for (int j = start; j < end; j++)
            {
                ins[Math.Abs(j+100)]++;

            }
        }


        for (int i = 0; i < ins.Length; i++)
        {
            if (ins[i] >= 2)
            {
                answer++;
            }

        }

        return answer;
         }
}