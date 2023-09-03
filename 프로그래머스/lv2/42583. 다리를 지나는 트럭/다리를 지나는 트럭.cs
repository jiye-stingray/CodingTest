using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        int answer = 0;

        Queue<int> queue = new Queue<int>();
        int index = 0;
        int currentW = 0;
        int time = 0;

        while (true)
        {
            if (index == truck_weights.Length) break;

            if (queue.Count == bridge_length) currentW -= queue.Dequeue();

            if (currentW + truck_weights[index] <= weight)
            {
                currentW += truck_weights[index];
                queue.Enqueue(truck_weights[index]);

                index++;
            }
            else
                queue.Enqueue(0);

           time++;
        }

        answer = time + bridge_length;
        return answer;
    }

}