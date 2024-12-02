using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickActivateSpine : MonoBehaviour
{
    [SerializeField]
    private GameObject spinePart;

     [SerializeField]
    private GameObject painPart;
     private Renderer painRenderer;

    [SerializeField]
    private Color myInitialColor;

    [SerializeField]
    private Color showColor;
    
    
    // Start is called before the first frame update
    void Start()
    {
    painRenderer = painPart.GetComponent<Renderer>();
    myInitialColor = painRenderer.material.color;

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            painPart.GetComponent<Renderer>();
        }*/
    }

    void OnMouseDown ()
    {
        painRenderer.material.color = showColor;
    }
}
