using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opacity : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public float revealSpeed = 1f;

    private bool waterOver = false;
    private GameObject waterCan;
    private Vector3 lastCanPosition;

    void Start()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        Color c = spriteRenderer.color;
        c.a = 0f;
        spriteRenderer.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        if (!waterOver || waterCan == null) return;

        // Bewegung des WaterCan-Objekts messen
        float movement = Vector3.Distance(waterCan.transform.position, lastCanPosition);

        if (movement > 0f)
        {
            Color c = spriteRenderer.color;
            c.a += movement * revealSpeed * Time.deltaTime;
            c.a = Mathf.Clamp01(c.a);
            spriteRenderer.color = c;
        }

        lastCanPosition = waterCan.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WaterCan"))
        {
            waterOver = true;
            waterCan = other.gameObject;
            lastCanPosition = waterCan.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("WaterCan"))
        {
            waterOver = false;
            waterCan = null;
        }
    }

    public bool IsFullyVisible => spriteRenderer.color.a >= 1f;
}