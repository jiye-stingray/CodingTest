using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n)
    {
        int answer = 0;
        List<int> dp = new List<int>();
        dp.Add(0);
        dp.Add(1);

        for (int i = 1; i < n; i++)
        {
            dp.Add((dp[i - 1] + dp[i]) % 1234567);
        }

        answer = dp[dp.Count - 1];

        return answer % 1234567;
    }
}