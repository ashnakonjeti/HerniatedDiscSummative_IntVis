using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextSpinalCord : MonoBehaviour
{

    public GameObject spinalcordText;


    // Start is called before the first frame update
    void Start()
    {
        spinalcordText.SetActive(false);
    }

    private void OnMouseOver()
    {
        spinalcordText.SetActive(true);
    }

    private void OnMouseExit()
    {
        spinalcordText.SetActive(false);
    }
}
