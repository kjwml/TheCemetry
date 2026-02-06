using UnityEngine;

[System.Serializable]
public class npcDialogue
{
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
