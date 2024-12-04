using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragandRotate : MonoBehaviour
{
    public float horizontalSpeed = 2.0f;
    private Quaternion initRot;

    // Start is called before the first frame update
    void Start()
    {
        initRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {}

    void OnMouseDrag ()
    {
        float z = horizontalSpeed*Input.GetAxis("Mouse X");
        transform.Rotate(0,0,-z);
    }
}
