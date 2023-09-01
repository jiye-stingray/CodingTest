using System;

public class Solution {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string[] s = { "aya", "ye", "woo", "ma" };



            for (int i = 0; i < babbling.Length; i++)
            {
                string b = babbling[i];

                int sCnt = 0;
                bool isOne = true;

                while (b != "")
                {
                    if (b.Contains(s[sCnt]))
                    {
                        b = b.Replace(s[sCnt], " ");
                    }

                    sCnt++;
                    if (sCnt >= 4)
                    {
                        if(!isOne)
                        {
                            break;
                        }
                        isOne = !isOne;
                        sCnt= 0;
                        
                    }

                }

                b = b.Replace(" ", "");

                if(b == "")
                {
                    answer++;
                }
            }


            return answer;
        }
}