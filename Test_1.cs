using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test_1 : MonoBehaviour
{
    private char spaceFlag = ' ';
    private string ReverseStr(string str)
    {
        StringBuilder resultStr = new StringBuilder();
        Stack<string> stackStr = new Stack<string>();
        string[] strArray = str.Split(spaceFlag);
        string currStr = string.Empty;
        char lastChar;
        char[] charArray;
        int length = strArray.Length;
        for (int i = 0; i < length; ++i)
        {
            currStr = strArray[i];
            charArray = currStr.ToCharArray();
            lastChar = charArray[charArray.Length - 1];
            if (lastChar.Equals('.') || lastChar.Equals(','))
            {
                currStr = currStr.Substring(0, currStr.Length - 1);
                stackStr.Push(currStr);
                while (stackStr.Count > 0)
                {
                    if (stackStr.Count == 1)
                        if (i == length - 1)
                             resultStr.Append(stackStr.Pop() + lastChar);
                        else
                            resultStr.Append(stackStr.Pop() + lastChar + spaceFlag);
                    else
                        resultStr.Append(stackStr.Pop() + spaceFlag);
                }
                stackStr.Clear();
            }
            else
            {
                stackStr.Push(currStr);
            }
        }
        return resultStr.ToString();
    }
}