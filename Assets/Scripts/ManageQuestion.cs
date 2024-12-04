using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ManageQuestion : MonoBehaviour
{
    [SerializeField]
    private ToggleGroup myToggleGroup;

    private GameObject userResponse;

    [SerializeField]
    private GameObject correctResponse;
    [SerializeField]
    private GameObject NegativeFB;
     [SerializeField]
    private GameObject PositiveFB;
    [SerializeField]
    private GameObject QuestionObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickConfirm()
    {
        //Retrieve click response
        Toggle selectedToggle = myToggleGroup.ActiveToggles().FirstOrDefault();
        userResponse = selectedToggle.gameObject;

        if (userResponse == correctResponse)
        {
            //Trigger positive feedback
            PositiveFB.SetActive(true);
        }
        else
        {
            //Trigger negative feedback
            NegativeFB.SetActive(true);
        }

        for (int i= 0; i < QuestionObject.transform.childCount; i++)
        {
            QuestionObject.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }
    }
}

