using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RAConverter : MonoBehaviour {
        



    public string RTAConvert(string inputValue)
    {

        char[] CorrectChars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M', 'v', 'x', 'l', 'c', 'd', 'm' };
        if (inputValue.All(c => CorrectChars.Contains(c)) == false)
            return "Invalid characters";

        Dictionary<char, int> d = new Dictionary<char, int>();
        d.Add('I', 1);
        d.Add('V', 5);
        d.Add('X', 10);
        d.Add('L', 50);
        d.Add('C', 100);
        d.Add('D', 500);
        d.Add('M', 1000);
        d.Add('v', 5000);
        d.Add('x', 10000);
        d.Add('l', 50000);
        d.Add('c', 100000);
        d.Add('d', 500000);
        d.Add('m', 1000000);

        char[] inputArray = inputValue.ToCharArray();
        int result = 0;
        for (int i = 0; i < inputArray.Length - 1; i++)
            if (d[inputArray[i]] < d[inputArray[i + 1]])
                result -= d[inputArray[i]];
            else
                result += d[inputArray[i]];
        result += d[inputArray[inputArray.Length - 1]];
        if (result > 1000000)
            return ">1000000";
        return result.ToString();
    }
}
