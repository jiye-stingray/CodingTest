using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
   public bool solution(string s)
{
     
    int balance = 0;  // 괄호의 균형을 유지하기 위한 변수

    foreach (char c in s)
    {
        if (c == '(')
        {
            balance++;
        }
        else if (c == ')')
        {
            if (balance <= 0) return false;
            balance--;
        }
    }

    return balance == 0;

   }
}