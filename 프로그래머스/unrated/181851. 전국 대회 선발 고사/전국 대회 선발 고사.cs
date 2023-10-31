using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        List<Tuple<int,int>> list = new List<Tuple<int,int>>();

        for (int i = 0; i < rank.Length; i++)
        {
            if (attendance[i])
            {
                list.Add(new Tuple<int, int>(i, rank[i]));
            }
        }

        list.Sort((x, y) => x.Item2.CompareTo(y.Item2));

        int a = list[0].Item1;
        int b = list[1].Item1;
        int c = list[2].Item1;

        answer = 10000 * a + 100 * b + c;

        return answer;
    }
}