using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float MoveSpeed = 6f;
    public float JumpSpeed = 12f;

    public GroundChecker GroundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxis("Horizontal") * MoveSpeed,
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if(GroundCheck.IsGrounded == true)
            {
                rbody.velocity = new Vector2(
                rbody.velocity.x,
                JumpSpeed);
            }
        }
    }
}
