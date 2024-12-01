using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextOuterHerniated : MonoBehaviour
{

    public GameObject OuterHerniatedText;


    // Start is called before the first frame update
    void Start()
    {
        OuterHerniatedText.SetActive(false);
    }

    private void OnMouseOver()
    {
        OuterHerniatedText.SetActive(true);
    }

    private void OnMouseExit()
    {
        OuterHerniatedText.SetActive(false);
    }
}
