using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class ManageQuiz : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> questionsList;

    [SerializeField]
    private int questionCollectionSize = 3;

    private int index = 0;
    [SerializeField]
    private GameObject finalPanel;
    [SerializeField]
    private GameObject questionPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNext()
    {
        for (int i = 0; i < questionPanel.transform.childCount; i++)
        {
            questionPanel.transform.GetChild(i).gameObject.SetActive(false);
        }

        if (index < questionCollectionSize)
        {
        //pick up a random question from the list and set game object as active
        int listID = Random.Range(0,questionsList.Count);
        questionsList[listID].SetActive(true);
        //Remove object from list
        questionsList.RemoveAt(listID);
        index +=1;
        }
        else
        {
            finalPanel.SetActive(true);
        }
    }
}
