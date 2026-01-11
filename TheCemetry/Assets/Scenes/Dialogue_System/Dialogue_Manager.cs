using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dialogue_Manager : MonoBehaviour
{
    private Queue<string> sentences;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentences = new Queue<string>(); 
    }
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
    }
}
