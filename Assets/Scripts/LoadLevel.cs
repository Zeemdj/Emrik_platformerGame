using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int MinimumScoreNeeded = 0;
    public string SceneToLoad = "Level1";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*När "Player" går in i ett objekt med detta scriptet och har mer eller lika mycket poäng som "MinimumScoreNeeded" 
         laddas banan om och sätter "Score" och "keys" till 0 */

        if (collision.tag == "Player" && Point.score >=MinimumScoreNeeded)
        {
            SceneManager.LoadScene(SceneToLoad);
            Point.score = 0;
            Key.keys = 0;
        }
    }






}
