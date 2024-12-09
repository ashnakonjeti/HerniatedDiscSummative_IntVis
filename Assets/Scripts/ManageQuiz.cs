using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.Properties;
using UnityEngine;

public class ManageQuiz : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> questionsList;

    [SerializeField]
    private int questionCollectionSize = 3;

    public int endCounter;
    [SerializeField]
    private GameObject finalPanel;
    [SerializeField]
    private GameObject questionPanel;

    

    int listID;
    public void OnClickNext()
    {
        for (int i = 0; i < questionPanel.transform.childCount; i++)
        {
            questionPanel.transform.GetChild(i).gameObject.SetActive(false);
        }

       

        if (endCounter < questionCollectionSize)
        {
            
            //pick up a random question from the list and set game object as active
            listID = Random.Range(0, questionsList.Count-1);
            questionsList[listID].SetActive(true);
            //Remove object from list
            questionsList.RemoveAt(listID);
            endCounter += 1;
            
            //Debug.Log("Other Run:" + endCounter);
        }
        else
        {
            Debug.Log("Final Panel");
            finalPanel.SetActive(true);
        }
    }
}
