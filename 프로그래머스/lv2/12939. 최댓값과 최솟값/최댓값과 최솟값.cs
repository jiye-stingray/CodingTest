using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
          string answer = "";
            string[] ss = s.Split(" ");
            int[] ints = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
            {
                int v = Convert.ToInt32(ss[i]);
                ints[i] = v;
            }

            int max = ints.Max();
            int min = ints.Min();

            answer = min + " " + max;

            return answer;
    }
}