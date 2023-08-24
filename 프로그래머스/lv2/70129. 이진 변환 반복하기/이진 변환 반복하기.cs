using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
        int zeroCnt = 0;

        int DestroyZero(string s)
        {
            int len = 0;

            foreach (char item in s)
            {
                if(item == '0')
                {
                    zeroCnt++;
                }
            }
            
            len = s.Replace("0","").Length;

            return len;
        }

        public int[] solution(string s)
        {
            int[] answer = new int[2];
            int cnt = 0;
            

            while(s != "1")
            {
                cnt++;
                int num =  DestroyZero(s);
                s = Convert.ToString(num, 2);       // 이진수로 변환
            }

            answer[0] = cnt;
            answer[1] = zeroCnt;
            return answer;
        }
}