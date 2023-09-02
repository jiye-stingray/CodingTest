using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Solution
    {

        public int solution(int X, int Y, char[,] map)
        {
            int answer = -1;

            char[,] maps = map;
            bool[,] boolMaps = new bool[X, Y];


            int distance = 1;
            Queue<Tuple<int, int, int>> queue = new Queue<Tuple<int, int, int>>();
            queue.Enqueue(new Tuple<int, int, int>(0, 0, distance));

            int[] dx = new int[] { -1, 0, 1, 0 };
            int[] dy = new int[] { 0, -1, 0, 1 };


            while (queue.Count > 0)
            {
                Tuple<int, int, int> tuple = queue.Dequeue();
                int nn = tuple.Item1;
                int mm = tuple.Item2;
                int dis = tuple.Item3;

                for (int i = 0; i < 4; i++)
                {
                    int newX = nn + dx[i];
                    int newY = mm + dy[i];
                    
                    if (newX == X - 1 && newY == Y - 1) return dis + 1; 

                    if (newX > X - 1 || newY > Y - 1 || newX < 0 || newY < 0) continue;

                    if (maps[newX, newY] != '0')
                    {
                        if (boolMaps[newX, newY]) continue;
                        queue.Enqueue(new Tuple<int, int, int>(newX, newY, dis + 1));
                        boolMaps[newX, newY] = true;
                        answer = dis + 1;

                    }
                }
            }

            return answer;
        }



    }


    static void Main(string[] args)
    {
        Solution s = new Solution();

        string? n = Console.ReadLine();
        string[] nn = n!.Split(' ');

        int Yint = Convert.ToInt32(nn[0]);
        int Xint = Convert.ToInt32(nn[1]);

        char[,] map = new char[Xint, Yint];
        for (int i = 0; i < Yint; i++)
        {
            string? ins = Console.ReadLine();
            for (int j = 0; j < Xint; j++)
            {
                if(ins is not null) 
                    map[j, i] = ins[j];

            }
        }
        Console.WriteLine(s.solution(Xint, Yint, map));

        return;
    }
}