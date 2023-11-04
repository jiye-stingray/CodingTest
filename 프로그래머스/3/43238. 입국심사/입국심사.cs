using System;

public class Solution {
    public long solution(int n, int[] times) {
        long answer = 0;

        Array.Sort(times); 
        long[] t = Array.ConvertAll(times,val => (long)val);

        long start = 1;
        long end = (long)n * t[0];
        answer = end;
        long mid = 0;

        while(start <= end)
        {
            mid = (start + end) / 2;

            long pCnt = 0;
            for (int i = 0; i < t.Length; i++)
            {
                pCnt += mid / t[i];
            }

            if(pCnt < n)
            {
                start = mid + 1;
            }
            else
            {
                answer = mid;
                end = mid - 1;
            }
        }
        return answer;

    }
}