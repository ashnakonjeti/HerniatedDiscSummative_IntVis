using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void StopAnimation ()
    {
        myAnimator.SetBool("Stop", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
