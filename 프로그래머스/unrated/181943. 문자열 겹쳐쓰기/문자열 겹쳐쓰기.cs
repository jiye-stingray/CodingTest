using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";

        string ss = my_string.Substring(overwrite_string.Length + s);

        my_string = my_string.Substring(0,s);


        answer = my_string + overwrite_string + ss;

        return answer;
    }
}