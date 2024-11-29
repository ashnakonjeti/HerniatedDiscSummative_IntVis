using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{


    [SerializeField]

    Transform myObjTransform;

    private Vector3 myInitialPos;

    private Quaternion myInitialRot;


    // Start is called before the first frame update
    void Start()
    {
        myInitialPos = transform.position;
        myInitialRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.5f, 0.0f, 0.0f, Space.Self);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.5f, 0.0f, 0.0f, Space.Self);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, 0.0f, 0.3f, Space.Self);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, 0.0f, -0.3f, Space.Self);
        }

        transform.LookAt(myObjTransform, transform.up);
    }
}
