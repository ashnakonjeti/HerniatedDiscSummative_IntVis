using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextOuterHealthy : MonoBehaviour
{

    public GameObject OuterHealthyText;


    // Start is called before the first frame update
    void Start()
    {
        OuterHealthyText.SetActive(false);
    }

    private void OnMouseOver()
    {
        OuterHealthyText.SetActive(true);
    }

    private void OnMouseExit()
    {
        OuterHealthyText.SetActive(false);
    }
}
