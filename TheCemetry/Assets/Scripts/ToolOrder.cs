using UnityEngine;

public class ToolOrder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform BrownDirtParent;
    public Transform GreenDirtParent;
    public Transform RockParent;
    public GameObject spongeTool;
    public GameObject brushTool;
    public GameObject shovelTool;
    public GameObject wateringCanTool;
    public GameObject clothTool;
    
    void Start()
    {
            spongeTool.SetActive(true);
            brushTool.SetActive(false);
            shovelTool.SetActive(false);
            wateringCanTool.SetActive(false);
            clothTool.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
         if (BrownDirtParent.childCount ==0)
        {
            spongeTool.SetActive(true);
            brushTool.SetActive(true);
            shovelTool.SetActive(false);
            wateringCanTool.SetActive(false);
            clothTool.SetActive(false);
        }


        if (GreenDirtParent.childCount ==0 )
        {
            spongeTool.SetActive(true);
            brushTool.SetActive(true);
            shovelTool.SetActive(true);
            wateringCanTool.SetActive(false);
            clothTool.SetActive(false);
        }
    

        if (RockParent.childCount ==0 )
        {
            spongeTool.SetActive(true);
            brushTool.SetActive(true);
            shovelTool.SetActive(true);
            wateringCanTool.SetActive(true);
            clothTool.SetActive(false);
        }
    }
}