using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    //"Static" variabeln är samma i alla scripts och tillgänglig från alla scripts
    public static int score;

    public int amount = 1;

    private float spinSpeed = 180;

    //När "Player" går in i en "coin" så försvinner den och "Player" får ett poäng
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            Point.score += amount;
        }
    }

    //Roterar objektet
    private void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
