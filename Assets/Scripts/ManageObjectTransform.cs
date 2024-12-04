using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObjectTransform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickButton(float angleOnY)
    {
        transform.Rotate(0.0f,angleOnY,0.0f,Space.Self);
    }
}
