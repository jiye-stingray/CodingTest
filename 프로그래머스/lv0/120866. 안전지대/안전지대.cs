using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] board)
    {
        int answer = 0;

        List<Tuple<int,int>> bombList = new List<Tuple<int,int>>();
 
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i,j] == 1)
                {
                    bombList.Add(new Tuple<int,int>(i,j));          // 폭탄의 위치 인덱스
                }
            }
        }

        int[] dx = new int[] { -1, 0, 1, 0 };
        int[] dy = new int[] { 0, 1, 0, -1 };

        for (int i = 0; i < bombList.Count; i++)
        {
            int x = bombList[i].Item1;
            int y = bombList[i].Item2;

            for (int xi = 0; xi < 4; xi++)
            {
                for (int yj = 0; yj < 4; yj++)
                {
                    int xx = x + dx[xi];
                    int yy = y + dy[yj];

                    if (xx >= 0 && xx < board.GetLength(0) && yy >= 0 && yy < board.GetLength(1))
                        board[xx, yy] = 1;
                }
            }
        }

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 1) continue;
                answer++;

            }
        }



        return answer;
    }
}