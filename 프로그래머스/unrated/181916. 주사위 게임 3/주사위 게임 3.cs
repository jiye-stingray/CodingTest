using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;

        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] ins = new int[] {a,b, c, d };
        Array.Sort(ins);
        for (int i = 0; i < ins.Length; i++)
        {
            if (map.ContainsKey(ins[i]))
            {
                map[ins[i]]++;
            }
            else
                map.Add(ins[i], 1);
        }


        int p = 0;
        int q = 0;

        switch (map.Count)
        {
            case 1:
                return 1111 * ins[0];
            case 2:

                if (map[ins[0]] == 2)
                {

                    p = ins[0];
                    q = ins[3];

                    return (p + q) * Math.Abs(p - q);

                }
                else
                {
                    int m = map.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                    p = m;
                    q = map.FirstOrDefault(item => item.Value == 1).Key;

                    return (int)Math.Pow((10 * p + q), 2);
                }
            case 3:

                int max = map.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                map.Remove(max);


                p = map.FirstOrDefault(item => item.Value == 1).Key;
                map.Remove(p);
                q = map.FirstOrDefault(item => item.Value == 1).Key;

                return q * p;
            case 4:
                return ins.Min();
            default:
                break;
        }

        return answer;
    }
}