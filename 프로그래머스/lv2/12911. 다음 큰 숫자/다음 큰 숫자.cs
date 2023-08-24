using System;

class Solution 
{
    public int solution(int n) 
    {
            int answer = 0;
            bool same = false;

            int len = Convert.ToString(n,2).Replace("0","").ToString().Length;

            while (!same)
            {
                int num = ++n;
                if(len == Convert.ToString(num,2).Replace("0","").ToString().Length)
                {
                    answer = num;
                    same = true;
                }

            }

            return answer;
    }
}