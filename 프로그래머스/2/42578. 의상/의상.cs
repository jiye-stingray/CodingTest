using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[,] clothes)
        {
        int answer = 1;

        Dictionary<string, int> dic = new Dictionary<string, int>();

        List<string> typeList = new List<string>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (dic.ContainsKey(clothes[i, 1]))
            {
                dic[clothes[i, 1]]++;
            }
            else
            {
                dic.Add(clothes[i, 1], 2);
                typeList.Add(clothes[i, 1]);
            }
        }
        Console.WriteLine(dic.Count);

        for (int i = 0; i < typeList.Count; i++)
        {
             answer *= dic[typeList[i]];
        }

        return answer - 1;
        }
}