using UnityEngine;

public class ToolOrder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform BrownDirtParent;
    public Transform GreenDirtParent;
    public Transform RockParent;
    public Transform shineGraveStone;
    public GameObject spongeTool;
    public GameObject brushTool;
    public GameObject shovelTool;
    public GameObject wateringCanTool;
    public GameObject clothTool;
    private Opacity shineOpacity;

    
    void Start()
    {
            spongeTool.SetActive(true);
            brushTool.SetActive(false);
            shovelTool.SetActive(false);
            wateringCanTool.SetActive(false);
            clothTool.SetActive(false);

        if (shineGraveStone != null)
        {
            shineOpacity = shineGraveStone.GetComponent<Opacity>();

        }
    }

    private bool clothActivated = false;

    // Update is called once per frame
    void Update()
    {
        // Erst alles deaktivieren
        spongeTool.SetActive(true);
        brushTool.SetActive(false);
        shovelTool.SetActive(false);
        wateringCanTool.SetActive(false);
        clothTool.SetActive(false);

        // 1️⃣ Brauner Dreck NOCH da → Sponge
        if (BrownDirtParent.childCount > 0)
        {
            spongeTool.SetActive(true);
            return;
        }

        // 2️⃣ Grüner Dreck NOCH da → Brush
        if (GreenDirtParent.childCount > 0)
        {
            brushTool.SetActive(true);
            return;
        }

        // 3️⃣ Steine NOCH da → Shovel
        if (RockParent.childCount > 0)
        {
            shovelTool.SetActive(true);
            return;
        }

        // 4️⃣ Alles weg → Watering Can

        // 4️⃣ Alles sauber → Watering Can (Opacity erhöhen)
        if (shineOpacity != null && !shineOpacity.IsFullyVisible)
        {
            wateringCanTool.SetActive(true);
            return;
        }

        // 5️⃣ Opacity = 1 → Cloth
        if (!clothActivated && shineOpacity != null && shineOpacity.IsFullyVisible)
        {
            clothActivated = true;
            clothTool.SetActive(true);
        }
    }
}