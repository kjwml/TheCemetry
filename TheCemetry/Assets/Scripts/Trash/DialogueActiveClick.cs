using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActiveClick : MonoBehaviour
{

    public ToolTyp toolType;
    public TriggerDialogue dialogue;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        dialogue.UseTool(toolType);
    }
}
