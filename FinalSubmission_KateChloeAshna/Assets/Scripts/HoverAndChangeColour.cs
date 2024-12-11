using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script for hovering over an object so that it changes colour and raises a text box UI popup window
public class HoverAndChangeColour : MonoBehaviour
{

    Color mouseOverColor = new Color(1f, 1f, 0.61f, 0.7f);

    Color originalColor;

    MeshRenderer meshRenderer;


    // Start is called before the first frame update
    void Start()
    {
    
        //Fetch mesh renderer component from game object
        meshRenderer = GetComponent<MeshRenderer>();

        //Fetch the origiunal colour of the game object
        originalColor = meshRenderer.material.color;
    }

    void OnMouseOver()
    {
        //Change the color of the game object to new colour when the nouse is over game object
        meshRenderer.material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        //Reset the color of the game object back to normal
        meshRenderer.material.color = originalColor;
    }

}
