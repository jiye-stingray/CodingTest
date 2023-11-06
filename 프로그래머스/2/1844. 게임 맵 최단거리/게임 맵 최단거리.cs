using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
public int solution(int[,] maps)
        {
            int h;
            int v;

            int answer = 0;
            h = maps.GetLength(0);
            v = maps.GetLength(1);

            bool isEnd = false; 
            
            Queue<Tuple<int,int,int>> _queue = new Queue<Tuple<int, int, int>>();



            _queue.Enqueue(new Tuple<int, int, int>(0, 0, 1));
            
            // 방문 표시를 위한 맵 2차원 배열 
            bool[,] bools = new bool[h,v];


            // 델타 값
            int[] dx = new int[] { -1, 0, 1, 0 };
            int[] dy = new int[] { 0, 1, 0, -1 };

            while(_queue.Count > 0)
            {
                var current = _queue.Dequeue();     // 현재 위치
                int x = current.Item1;
                int y = current.Item2;
                int dis = current.Item3;

                if(x == h - 1 && y == v - 1)
                {
                    isEnd= true;
                    answer = dis;
                    return answer;
                }

                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];


                    if(newX >= 0 && newY >= 0 && newX < h && newY < v && !bools[newX,newY] && maps[newX,newY] == 1 )
                    {
                        _queue.Enqueue(new Tuple<int, int, int>(newX, newY, dis + 1));
                        bools[newX,newY] = true;
                    }
                    
                }
            }

            if (!isEnd) return -1;
            
            return answer;
        }
    }
