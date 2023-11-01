using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] { };
        List<int> list = new List<int>();

        for (int i = l; i <= r; i++)
        {
            string s = i.ToString();
            s = string.Concat(s.Where(x => x != '0'));
            s = string.Concat(s.Where(x => x != '5'));

            if(s == "")
            {
                list.Add(i);
            }
        }
        
        if (list.Count <= 0) list.Add(-1);
        answer = list.ToArray();
        return answer;
    }
}