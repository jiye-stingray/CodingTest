public class Solution {
       public long solution(long n)
        {
            long answer = 0;
            
           n = n%1234567;

            bool one = true;
            long num1 = 0;
            long num2 = 0;

            for (int i = 0; i < n + 1; i++)
            {
                if (i == 0)
                {
                    num1 = 0;
                    continue;
                }
                else if(i == 1)
                {
                    num2 = 1;
                    continue;
                }

                answer = (num1 + num2)%1234567;

                if(one)
                {
                    num1 = (num1 + num2)%1234567;
                    one = false;
                }
                else
                {
                    num2 = (num1 + num2)%1234567;
                    one = true;
                }
            }

            return answer%1234567;
        }
}