using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Typewriter : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public TextMeshProUGUI inputText;

    private string outputString = "";
    private int i = -1;
    public bool done;
    public int delay;

    void Update()
    {
        if(!done)
        {
            displayText.text = TypeWrite(inputText.text);
        }
    }
    private string TypeWrite(string input)
    {
        i++;
        char[] character = input.ToCharArray();
        outputString = outputString + character[i].ToString();
        if(i==character.Length-1)
        {
            done = true;
        }
        return outputString;
    }
}
