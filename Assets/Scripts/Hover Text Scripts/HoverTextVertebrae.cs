using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextVertebrae : MonoBehaviour
{

    public GameObject vertebraeText;


    // Start is called before the first frame update
    void Start()
    {
        vertebraeText.SetActive(false);
    }

    private void OnMouseOver()
    {
        vertebraeText.SetActive(true);
    }

    private void OnMouseExit()
    {
        vertebraeText.SetActive(false);
    }
}
