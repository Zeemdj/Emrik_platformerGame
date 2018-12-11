using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpriteChanger : MonoBehaviour
{
    public Sprite ClosedDoor;
    public Sprite OpenDoor;

    void Update()
    {
        //Om objectets sprite är "ClosedDoor" och spelaren har fler "keys" än "keysNeeded" byts spriten till "OpenDoor".
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == ClosedDoor && Key.keys >= DoorLoadLevel.keysNeeded)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = OpenDoor;
        }

        //Om objectets sprite är "OpenDoor" och spelaren har färre "keys" än "keysNeeded" byts spriten till "ClosedDoor".
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == OpenDoor && Key.keys < DoorLoadLevel.keysNeeded)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ClosedDoor;
        }
    }
}
