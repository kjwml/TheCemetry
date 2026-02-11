using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    [TextArea(3, 5)]
    public string[] dialogueLines;

    public TextMeshProUGUI dialogueText;
    public float typingSpeed = 0.05f;
    public float delayBetweenLines = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartDialogue());
    }

    IEnumerator StartDialogue()
    {
        for (int i = 0; i < dialogueLines.Length; i++)
        {
            dialogueText.text = "";

            yield return StartCoroutine(TypeLine(dialogueLines[i]));
            yield return new WaitForSeconds(delayBetweenLines);

            dialogueText.text = "";

        }
        dialogueText.text = "";

    }

    IEnumerator TypeLine(string line)
    {
        dialogueText.text = "";

        foreach (char letter in line)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
     }
 }
