using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)

        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

        void DisplayNextSentence ()
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }
            string sentence = sentences.Dequeue();
            Debug.Log(sentence);

        }

        void EndDialogue ()
        {
            Debug.Log("End of conversation.");
        }
    }
}
