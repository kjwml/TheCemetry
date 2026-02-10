using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Opacity : MonoBehaviour

{
    public float revealSpeed = 0.5f;
    private SpriteRenderer spriteRenderer;
    private bool waterOver = false;
    private Vector3 lastMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        Color c = spriteRenderer.color;
        c.a = 0f;
        spriteRenderer.color = c;

        lastMousePosition = Input.mousePosition;

    }

    // Update is called once per frame
    void Update()
    {
        if (!waterOver) return;

        Vector3 mouseDelta = Input.mousePosition - lastMousePosition;
        float movement = mouseDelta.magnitude;

        if (movement > 0f)
        {
            Color c = spriteRenderer.color;
            c.a += movement * revealSpeed * Time.deltaTime;
            c.a = Mathf.Clamp01(c.a);
            spriteRenderer.color = c;

        }

        lastMousePosition = Input.mousePosition;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WaterCan"))
            waterOver = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("WaterCan"))
            waterOver = false;
    }

    public bool IsFullyVisible
    {
        get { return spriteRenderer != null && spriteRenderer.color.a >= 1f; }
    }
}

