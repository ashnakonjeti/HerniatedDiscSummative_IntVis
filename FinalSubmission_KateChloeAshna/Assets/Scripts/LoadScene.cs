using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //this script will load the next scene by name which can be then edited in the inspector in Unity 
    
    public void LoadSceneByName(string sceneName)
    {
        StartCoroutine(DelayToLoadScene(sceneName));
    }

    private IEnumerator DelayToLoadScene(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);

    }
}
