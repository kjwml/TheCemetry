using UnityEngine;
using System;

[Serializable]
/// <summary>
/// Data for dialog fragment (participant + text)
/// </summary>
public class NPC_Monologue
{
    public string name;

    [TextArea(3, 10)]
    public string[] text;
}
   