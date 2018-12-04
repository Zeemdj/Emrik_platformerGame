using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLoadLevel : MonoBehaviour
{
    public string sceneBehindDoor = "Level2Continue";
    public int keysToOpen;
    public static int keysNeeded;


    // Om ett object med taggen "Player" som har fler "Keys" än "keysNeeded" laddas nästa scen.
    // tar bort antal "KeysNeeded" från "keys".
    // "OnTriggerEnter2D" händer bara så fort något nuddar en collider som är en trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && Key.keys >= keysToOpen)
        {
            SceneManager.LoadScene(sceneBehindDoor);
            Key.keys -= keysToOpen;
        }
    }

    //Gör så att "KeysNeeded är lika mycket som "keysToOpen".
    //"Update" händer så många gånger som möjligt varje frame"
    private void Update()
    {
        DoorLoadLevel.keysNeeded = keysToOpen;
    }
}
