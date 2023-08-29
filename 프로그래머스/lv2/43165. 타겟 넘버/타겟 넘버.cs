using System;
using System.Linq;

   public class Solution
    {
        int[] numbers = new int[] { };

        int target = 0;
        int answer = 0;

        public int solution(int[] numbers, int target)
        {
            this.numbers = numbers;
            this.target = target;

            Dfs(numbers[0],1);
            Dfs(-1 * numbers[0], 1);


            return answer;
        }

        private bool Dfs(int number, int index)
        {

            if(index == numbers.Length)
            {
                if(number == target)
                {
                    answer += 1;
                    return true;
                }

                return false;
            }

            Dfs(number + numbers[index], index + 1);
            Dfs(number - numbers[index], index + 1);

            return false;

        }
    }