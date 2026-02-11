using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAppereance : MonoBehaviour
{
    public float delay = 3f;
    public float fadeDuration = 2f;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        Color c = spriteRenderer.color;
        c.a = 0f;
        spriteRenderer.color = c;

        StartCoroutine(FadeIn());

    }

   
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(delay);

        float elapsed = 0f;
        Color c = spriteRenderer.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            c.a = Mathf.Lerp(0f, 1f, elapsed / fadeDuration);
            spriteRenderer.color = c;
            yield return null;
        }

        c.a = 1f;
            spriteRenderer.color = c;
    }
 }
