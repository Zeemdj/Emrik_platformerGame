using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpMovment : MonoBehaviour
{
    public float jumpSpeed = 10f;
    public float moveSpeed = 2f;

    public float jumpTimer = 0;

    public int timesJumped;
    public int jumpsUntillTurn;

    private Rigidbody2D rbody;

    public GroundChecker groundCheck;

    public bool left = true;

    // Hämtar "Rigidbody2D" componenten från objektet med detta script och sätter den i variabeln "rbody" när spelet startar
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        //En timer som räknar hur länge objektet är på marken
        if (groundCheck.isGrounded > 0)
        {
            jumpTimer += Time.deltaTime;
        }
        //Om objektet är på marken och "timesJumped" är lika med "jumpsUntillTurn" vänder objektet och "timesJumped" sätts till 0
        if (groundCheck.isGrounded > 0 && timesJumped == jumpsUntillTurn)
        {
            left = !left;
            timesJumped = 0;
        }
    }

    private void FixedUpdate()
    {
        /*Om "Enemy" är på marken, kollar åt höger och "jumpTimer" är större än 1, får grodan en "velocity" i både
        x (MoveSpeed) och y (JumpSpeed) axeln så att den hoppar åt höger.
        Sen sätter den "jumptimer" till 0 och ökar "timesJumped" med 1*/
        if (groundCheck.isGrounded > 0 && left == false && jumpTimer >= 1f)
        {
            rbody.velocity = new Vector2(moveSpeed, jumpSpeed);
            transform.localScale = new Vector3(-1, 1, 1);
            jumpTimer = 0;
            timesJumped += 1;
        }
        /*Om "Enemy" är på marken, kollar åt vänster och "jumpTimer" är större än 1, får grodan en "velocity" i både
        x (-MoveSpeed) och y (JumpSpeed) axeln så att den hoppar åt vänster.
        Sen sätter den "jumptimer" till 0 och ökar "timesJumped" med 1*/
        else if (groundCheck.isGrounded > 0 && left == true && jumpTimer >= 1f)
        {
            rbody.velocity = new Vector2(-moveSpeed, jumpSpeed);
            transform.localScale = new Vector3(1, 1, 1);
            jumpTimer = 0;
            timesJumped += 1;
        }

    }

}
