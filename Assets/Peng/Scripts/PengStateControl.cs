using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengStateControl : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forward = Input.GetKey("w");
        bool jump = Input.GetKey("space");

        if (jump) 
        {
            animator.SetBool("jump", true);
        }

        if (!jump) 
        {
            animator.SetBool("jump", false);
        }


        if (forward) 
        {
            animator.SetBool("walking", true);
        }

        if (!forward)
        {
            animator.SetBool("walking", false);
        }
        
    }

}
