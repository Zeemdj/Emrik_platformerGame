using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalMovment : MonoBehaviour {

    public float speed = 2f;
    public bool left = true;


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
            left = !left;
        }
    }

    //Gör så att "Fienden" rör sig verticalt. Om "Left == true" åker den ner, annars up.
    //(vector2) ändrar från vector3
    private void FixedUpdate()
    {

        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.up * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.up * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
}
