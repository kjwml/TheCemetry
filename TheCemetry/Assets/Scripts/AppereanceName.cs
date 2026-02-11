using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppereanceName : MonoBehaviour
{
    public float revealSpeed = 0.5f;
    private SpriteRenderer spriteRenderer;
    private bool clothOver = false;
    private Vector3 lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            Color c = spriteRenderer.color;
            c.a = 0f;
            spriteRenderer.color = c;
        }
        

        lastMousePosition = Input.mousePosition;
        }
            // Update is called once per frame
            void Update()
    {
        if (!clothOver) return;

        Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
        float movement = mouseDelta.magnitude;

        if (movement > 0f && spriteRenderer != null)
        {
            Color c = spriteRenderer.color;
            c.a += movement * revealSpeed * Time.deltaTime;
            c.a = Mathf.Clamp01(c.a);
            spriteRenderer.color = c;
        }

        lastMousePosition = Input.mousePosition;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cloth")) 
        {
            clothOver = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Cloth")) 
        {
            clothOver = false;

        }
    }
    }

        
