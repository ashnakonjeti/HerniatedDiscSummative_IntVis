using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextInnerHerniated : MonoBehaviour
{

    public GameObject InnerHerniatedText;


    // Start is called before the first frame update
    void Start()
    {
        InnerHerniatedText.SetActive(false);
    }

    private void OnMouseOver()
    {
        InnerHerniatedText.SetActive(true);
    }

    private void OnMouseExit()
    {
        InnerHerniatedText.SetActive(false);
    }
}
