using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[] { };


        List<Tuple<int,int>> list = new List<Tuple<int,int>>();     // 사각형이 될 수 있는 조건 목록

        int all = brown + yellow;

        for (int i = 2; i < all / 2; i++)
        {
            if(all%i == 0)
            {
                Tuple<int, int> t = new Tuple<int, int>( all / i, i );
                list.Add(t);
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            Tuple<int, int> t = list[i];
            int x = t.Item1;
            int y = t.Item2;

            if((x - 2) * (y -2) == yellow)
            {
                answer = new int[] { y, x };
            }
        }

        return answer;
    }
}