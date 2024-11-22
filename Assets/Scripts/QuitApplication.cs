using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{
   //this script will quit my application 

   public void Quit()
   {
        Application.Quit();
        Debug.Log("Application has Quit");
   }
}
