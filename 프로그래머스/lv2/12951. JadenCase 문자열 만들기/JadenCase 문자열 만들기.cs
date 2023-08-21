using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
        public string solution(string s)
        {
            StringBuilder answer = new StringBuilder();

            s = s.ToLower();

            bool _isnew= true;

            for (int i = 0; i < s.Length; i++)
            {

                if (char.IsWhiteSpace(s[i]))
                {
                    answer.Append(" ");
                    _isnew = true;
                    continue;
                }

                if(_isnew)
                {
                    answer.Append(s[i].ToString().ToUpper());
                    _isnew = false;
                }
                else
                {
                    answer.Append(s[i]);
                }

            }

            return answer.ToString();
        }
}