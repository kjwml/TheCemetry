using UnityEngine;

[CreateAssetMenu(fileName = "NPC_Dialogue", menuName = "Scriptable Objects/New NPC Dialogue")]
public class NPC_Dialogue : ScriptableObject
{
    public Dialogue[] sentences;
}
