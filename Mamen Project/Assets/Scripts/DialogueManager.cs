using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject[] dialogueLines;
    private int i=0;
    private GameObject currentLine;
    // Start is called before the first frame update
    void Start()
    {
        currentLine = dialogueLines[0];
        currentLine.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLine.GetComponent<Typewriter>().done && i<dialogueLines.Length)
        {
            i++;
            Thread.Sleep(currentLine.GetComponent<Typewriter>().delay);
            currentLine.SetActive(false);
            currentLine = dialogueLines[i];
            currentLine.SetActive(true);
        }
    }
}
