using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineColorChange : MonoBehaviour
{
    private Renderer myRenderer;
    [SerializeField]
    private Color myInitialColor;
    [SerializeField]
    private Color highlightColor;

    [SerializeField]
    private Color pressedColor;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = transform.GetComponent<Renderer>();
        myInitialColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool isClicked = false;

    void OnMouseDown ()
    {
        if (isClicked)
        {
            myRenderer.material.color = myInitialColor;
        }
        else
        {
            myRenderer.material.color = pressedColor;
        }
        isClicked = !isClicked;
        
    }

}
