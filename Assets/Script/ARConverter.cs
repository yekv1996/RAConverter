using System;
using System.Linq;
using UnityEngine;

public class ARConverter : MonoBehaviour {

    public string ATRConvert(string inputValue)
    {
        char[] CorrectChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        if (inputValue.All(c => CorrectChars.Contains(c)) == false)
            return "Invalid characters";
        if (Convert.ToInt32(inputValue) > 1000000)
            return ">m";
        string[] resArray;
        string result = "";
        char[] inputArray = inputValue.ToCharArray();
        int count = 0;
        string f = "I", s = "V", th = "X";
        resArray = new string[inputArray.Length];
        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            if (count == 1)
            {
                f = "X";
                s = "L";
                th = "C";
            }
            else if (count == 2)
            {
                f = "C";
                s = "D";
                th = "M";
            }
            else if (count == 3)
            {
                f = "M";
                s = "v";
                th = "x";
            }
            else if (count == 4)
            {
                f = "x";
                s = "l";
                th = "c";
            }
            else if (count == 5)
            {
                f = "c";
                s = "d";
                th = "m";
            }
            else if (count == 6)
            {
                f = "m";
            }
            switch (inputArray[i])
            {
                case '0':
                    break;
                case '1':
                    resArray[i] = f;
                    break;
                case '2':
                    resArray[i] = f + f;
                    break;
                case '3':
                    resArray[i] = f + f + f;
                    break;
                case '4':
                    resArray[i] = f + s;
                    break;
                case '5':
                    resArray[i] = s;
                    break;
                case '6':
                    resArray[i] = s + f;
                    break;
                case '7':
                    resArray[i] = s + f + f;
                    break;
                case '8':
                    resArray[i] = s + f + f + f;
                    break;
                case '9':
                    resArray[i] = f + th;
                    break;
            }
            count++;
        }
        foreach (string str in resArray)
            result += str;
        return result;        
    }
}
