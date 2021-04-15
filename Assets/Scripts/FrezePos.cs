using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrezePos : MonoBehaviour
{

    Rigidbody rb;
    NinjaCombat ninjaCombat;
    Animator anim;

    public float jumpforce;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask GroundMask;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ninjaCombat = GameObject.FindObjectOfType<NinjaCombat>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, GroundMask);
        ninjaCombat = GameObject.FindObjectOfType<NinjaCombat>();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpforce);
        }
        if (isGrounded)
        {
            anim.SetBool("IsJumping", false);
        }
        if (!isGrounded)
            anim.SetBool("IsJumping", true);
        //if (rb.velocity.y < 0)
         //   anim.SetBool("IsJumping", true);
        if (ninjaCombat.isAttacking)
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
        else
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
}
