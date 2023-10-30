using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        List<string> list = new List<string>();
        int zeroCnt = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0) zeroCnt++;

            list.Add(numbers[i].ToString());
        }

        if (zeroCnt == numbers.Length) return "0";

        StringBuilder stringBuilder = new StringBuilder();
        list.Sort((x, y) => (y + x).CompareTo(x + y));


        for (int i = 0; i < numbers.Length; i++)
        {
            stringBuilder.Append(list[i]);
        }

        return stringBuilder.ToString();
    }
}