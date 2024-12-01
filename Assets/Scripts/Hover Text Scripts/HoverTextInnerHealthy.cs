using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextInnerHealthy : MonoBehaviour
{

    public GameObject InnerHealthyText;


    // Start is called before the first frame update
    void Start()
    {
        InnerHealthyText.SetActive(false);
    }

    private void OnMouseOver()
    {
        InnerHealthyText.SetActive(true);
    }

    private void OnMouseExit()
    {
        InnerHealthyText.SetActive(false);
    }
}
