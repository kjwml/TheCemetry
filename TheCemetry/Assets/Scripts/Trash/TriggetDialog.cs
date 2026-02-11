using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ToolTyp
{
   Sponge,
   Brush,
   Shovel,
   WateringCan,
   Cloth
}

public class TriggerDialogue : MonoBehaviour
{

    public GameObject speechBubble;
    public TMP_Text dialogueText;

    public string[] dialogue;

    public float wordSpeed = 0.05f;
    public float bubbleVisibleTime = 2f;

    private int index = 0;
    private bool isTyping = false;

    Vector2 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        speechBubble.SetActive(true);
    }

    public void UseTool(ToolTyp tool)
    {
    if ((int)tool != index) return;
    StopAllCoroutines();
    StartCoroutine (ShowDialogue());
    }

    IEnumerator ShowDialogue()
    {
        speechBubble.SetActive(true);
        dialogueText.text = "";

        foreach (char letter in dialogue[index])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }

        yield return new WaitForSeconds(bubbleVisibleTime);

        speechBubble.SetActive(false);
        index++;
    }
}