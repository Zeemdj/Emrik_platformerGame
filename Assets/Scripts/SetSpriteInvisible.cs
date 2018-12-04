using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    //Gör spriten osynlig när spelet startar
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

}
