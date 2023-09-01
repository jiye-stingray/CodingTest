using System;

    public class Solution
    {
        public int solution(int[,] dots)
        {
            int answer = 0;
            double x1 = Math.Abs(dots[0, 0] - dots[1, 0]);
            double y1 = Math.Abs(dots[0, 1] - dots[1, 1]);
            double x2 = Math.Abs(dots[2, 0] - dots[3, 0]);
            double y2 = Math.Abs(dots[2, 1] - dots[3, 1]);
            answer = CheckNum(x1, y1, x2, y2);
            if(answer == 1) return answer;

            x1 = Math.Abs(dots[0, 0] - dots[2, 0]);
            y1 = Math.Abs(dots[0, 1] - dots[2, 1]);
            x2 = Math.Abs(dots[1, 0] - dots[3, 0]);
            y2 = Math.Abs(dots[1, 1] - dots[3, 1]);
            answer = CheckNum(x1, y1, x2, y2);
            if (answer == 1) return answer;



            x1 = Math.Abs(dots[0, 0] - dots[3, 0]);
            y1 = Math.Abs(dots[0, 1] - dots[3, 1]);
            x2 = Math.Abs(dots[1, 0] - dots[2, 0]);
            y2 = Math.Abs(dots[1, 1] - dots[2, 1]);
            answer = CheckNum(x1, y1, x2, y2);
            if (answer == 1) return answer;



            return answer;
        }

        private int CheckNum(double x1, double x2, double y1, double y2)
        {

            if(x1 == x2 && y1 == y2) return 1;

            double xMax = Math.Max(x1, x2);
            double xMin = Math.Min(x1, x2);

            double yMax = Math.Max(y1, y2);
            double yMin = Math.Min(y1, y2);

            double xG = (xMax / xMin);
            double yG = (yMax / yMin);

            if ( xG == yG)
            {
                if ((xMax != 2 && xMin == 1) || 
                    (yMax != 2 && yMin == 1))
                {
                    return 0;
                }
                return 1;
            }
            return 0;
        }
    }