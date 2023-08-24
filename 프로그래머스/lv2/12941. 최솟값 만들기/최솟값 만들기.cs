using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) {
             int answer = 0;

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for (int i = 0; i < A.Length; i++)
            {
                int a = A[i];
                int b = B[i];

                answer += (a * b);
            }

            return answer;
    }
}