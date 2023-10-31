using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n, n];
        int cnt = 1;

        int i = 0;
        int j = 0;
        answer[i, j] = cnt++;

        int[] di = new int[] { 0, 1, 0, -1 };
        int[] dj = new int[] { 1, 0, -1, 0 };
        int dr = 0;

        while (cnt <= n * n)
        {
            int ni = i + di[dr];
            int nj = j + dj[dr];

            if ((ni >= 0 && ni < n) && (nj >= 0 && nj < n) && answer[ni, nj] == 0)
            {
                i = ni;
                j = nj;
                answer[i, j] = cnt++;
            }
            else
                dr = (dr + 1) % 4;
        }
        return answer;
    }
}