using System;
using System.Linq;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        if (a == b && b == c && c == d) return 1111 * a;

        int[] ints = new int[] { a, b, c, d };

        Array.Sort(ints);
        if (ints[0] != ints[1] && ints[1] != ints[2] && ints[2] != ints[3] && ints[0] != ints[3]) return ints.Min();


        if (ints[0] == ints[1] && ints[2] != ints[3] && ints[0] != ints[2] && ints[0] != ints[3])
            return ints[2] * ints[3];
        else if (ints[3] == ints[2] && ints[1] != ints[0] && ints[3] != ints[1] && ints[3] != ints[0])
            return ints[0] * ints[1];
        else if (ints[1] == ints[2] && ints[0] != ints[3] && ints[1] != ints[0] && ints[1] != ints[3])
            return ints[0] * ints[3];    


        if (ints[0] == ints[1] && ints[2] == ints[3])
            return (ints[0] + ints[2]) * Math.Abs(ints[0] - ints[2]);
        else if (ints[1] == ints[2] && ints[0] == ints[3])
            return (ints[1] + ints[0]) * Math.Abs(ints[1] - ints[0]);

                int p = 0;
        int q = 0;

        p = ints[0] == ints[1] ? ints[0] : ints[3];
        q = ints[0] == ints[1] ? ints[3] : ints[0];
            

        return (int)Math.Pow((10 * p + q),2);
    }
}