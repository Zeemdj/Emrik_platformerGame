using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalMovment : MonoBehaviour {

    public float Speed = 2f;
    public bool Left = true;


    private Rigidbody2D rbody;

    // Hämtar "Rigidbody2D" componenten från objektet med detta script och sätter den i variabeln "rbody" när spelet startar
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //Vänder på "Fienden" när den går in i en "InvisibleWall"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Left = !Left;
        }
    }

    //Gör så att "Fienden" rör sig verticalt. Om "Left == true" åker den ner, annars up.
    //(vector2) ändrar från vector3
    private void FixedUpdate()
    {

        if (Left == true)
        {
            rbody.velocity = -(Vector2)transform.up * Speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.up * Speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
}
