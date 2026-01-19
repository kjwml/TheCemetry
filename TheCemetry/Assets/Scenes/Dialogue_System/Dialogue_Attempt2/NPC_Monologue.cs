using UnityEngine;
using System;
using Unity.VisualScripting;

[Serializable]
/// <summary>
/// Data for dialog fragment (participant + text)
/// </summary>
public class NPC_Monologue
{
    public string name;

    [TextArea(3, 10)]
   [Inspectable] public string text;
}
   