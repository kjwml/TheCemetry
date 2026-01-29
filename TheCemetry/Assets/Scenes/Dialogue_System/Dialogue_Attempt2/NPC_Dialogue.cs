using UnityEngine;

[CreateAssetMenu(fileName = "NPC_Dialogue", menuName = "Scriptable Objects/New NPC Dialogue", order = 1)]
public class NPC_Dialogue : ScriptableObject
{
    public NPC_Monologue[] sentences;
}