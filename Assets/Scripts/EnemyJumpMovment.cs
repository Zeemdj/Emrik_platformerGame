using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpMovment : MonoBehaviour
{
    public float JumpSpeed = 10f;
    public float MoveSpeed = 2f;

    public float jumpTimer = 0;

    public int timesJumped;
    public int jumpsUntillTurn;

    private Rigidbody2D rbody;

    public GroundChecker groundCheck;

    public bool Left = true;

    // Hämtar "Rigidbody2D" componenten från objektet med detta script och sätter den i variabeln "rbody" när spelet startar
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        //En timer som räknar hur länge objektet är på marken
        if (groundCheck.IsGrounded > 0)
        {
            jumpTimer += Time.deltaTime;
        }
        //Om objektet är på marken och "timesJumped" är lika med "jumpsUntillTurn" vänder objektet och "timesJumped" sätts till 0
        if (groundCheck.IsGrounded > 0 && timesJumped == jumpsUntillTurn)
        {
            Left = !Left;
            timesJumped = 0;
        }
    }

    private void FixedUpdate()
    {
        /*Om "Enemy" är på marken, kollar åt höger och "jumpTimer" är större än 1, får grodan en "velocity" i både
        x (MoveSpeed) och y (JumpSpeed) axeln så att den hoppar åt höger.
        Sen sätter den "jumptimer" till 0 och ökar "timesJumped" med 1*/
        if (groundCheck.IsGrounded > 0 && Left == false && jumpTimer >= 1f)
        {
            rbody.velocity = new Vector2(MoveSpeed, JumpSpeed);
            transform.localScale = new Vector3(-1, 1, 1);
            jumpTimer = 0;
            timesJumped += 1;
        }
        /*Om "Enemy" är på marken, kollar åt vänster och "jumpTimer" är större än 1, får grodan en "velocity" i både
        x (-MoveSpeed) och y (JumpSpeed) axeln så att den hoppar åt vänster.
        Sen sätter den "jumptimer" till 0 och ökar "timesJumped" med 1*/
        else if (groundCheck.IsGrounded > 0 && Left == true && jumpTimer >= 1f)
        {
            rbody.velocity = new Vector2(-MoveSpeed, JumpSpeed);
            transform.localScale = new Vector3(1, 1, 1);
            jumpTimer = 0;
            timesJumped += 1;
        }

    }

}
