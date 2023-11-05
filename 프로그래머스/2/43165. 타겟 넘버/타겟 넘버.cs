using System;

public class Solution {
    int target;
    int answer = 0;
    int[] numbers = new int[] { };
    public int solution(int[] numbers, int target)
    {
        this.target = target;
        this.numbers = numbers;

        TargerFind(0,0);

        return answer;
    }


    public void TargerFind(int n, int index)
    {
        if(index == numbers.Length)
        {

            if (n == target)
            {
                answer++;
            }

           return;
        }

        TargerFind(n + numbers[index], index + 1);
        TargerFind(n - numbers[index], index + 1);

    }
}