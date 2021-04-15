using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaAnimation : MonoBehaviour
{
    private Animator anim;
    float VelocityZ = 0.0f;

    public float accleration = 2.0f;
    public float deceleration = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //getting input
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool backPressed = Input.GetKey(KeyCode.S);
        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);

        //forward jump
        if (jumpPressed && forwardPressed)
        {
            anim.SetBool("IsForwardJump", true);
        }
        else
        {
            anim.SetBool("IsForwardJump", false);
        }

        //update animator parameters
        anim.SetFloat("VelocityZ", VelocityZ);
    }
}
