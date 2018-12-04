using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //Static gör att "keys" är samma i varje script och att det gåt att hämta variabeln i varje script.
    public static int keys;

    public int keyValue = 1;

    //Om objectet koliderar med "Player" försvinner spriten och "keys" ökar med "keyValue" 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            Key.keys += keyValue;
        }
    }
}
