using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovment : MonoBehaviour
{
    public float Speed = 2f;
    public bool Left = true;

    private Rigidbody2D rbody;

    // Hämtar "Rigidbody2D" componenten från objektet med detta script och sätter den i variabeln "rbody" när spelet startar
    //"Start" händer bara näs spelet startar
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //Vänder på "Fienden" när den går in i ett objeckt med taggen "InvisibleWall"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Left = !Left;
        }
    }

    //(Vector2) ändrar från vector3 eftersom man inte använder "Z" i 2D spel.
    //"FixedUpdate" händer 50 gånger varje frame.
    private void FixedUpdate()
    {

        if (Left == true)
        {
            //Gör så att fienden rör sig horisontalt genom att den ger fienden en "velocity"
            rbody.velocity = -(Vector2)transform.right * Speed;
            //Ändrar skalan på objectet så spriten byter håll
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //Gör så att fienden rör sig horisontalt genom att den ger fienden en "velocity"
            rbody.velocity = (Vector2)transform.right * Speed;
            //Ändrar skalan på objectet så spriten byter håll
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
}
