using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
   public float transparencyLevel = 0.5f; 
   public float fadeSpeed = 0.5f;
   public string targetTag = "WateringCan";
    private Renderer appereance;
    private Color originalColor;
    private Color currentColor;
    void Start()
    {
        appereance = GetComponent<Renderer>();
        currentColor = appereance.material.color;
        currentColor.a = 0f;
        appereance.material.color = currentColor;

        originalColor = currentColor;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            currentColor.a += fadeSpeed * Time.deltaTime;
            currentColor.a = Mathf.Clamp(currentColor.a, 0f, 1f);
            appereance.material.color = currentColor;

        }
}
}
