using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;

    public GroundChecker GroundCheck;

    private Rigidbody2D rbody;

    // Hämtar "Rigidbody2D" componenten från objektet med detta script och sätter den i variabeln "rbody" när spelet startar
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //Gör så att man kan styra spelaren Horisontalt med knapparna som "Horizontal" är satt till (A,D /högerpil, vänsterpil)
    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed,   rbody.velocity.y);

        //Ger spelaren en "velocity" uppåt när man trycker "Jump" och nuddar marken så att man hoppar.
        if (Input.GetButtonDown("Jump"))
        {
            if (GroundCheck.isGrounded > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
    }

    //Om "Player" är i en "Collider" med taggen "Ladder" kan man gå verticalt
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ladder")
        {
            rbody.velocity = new Vector2(Input.GetAxis("Vertical") * moveSpeed, rbody.velocity.x);
        }
    }
}
