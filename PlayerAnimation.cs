using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    //private bool isAnimating = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetButton("Horizontal") || Input.GetButton("Vertical")))
        {
            animator.SetBool("isWalking", true);
            //isAnimating = true;
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
