using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dialogue_Graveyard : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }
}
