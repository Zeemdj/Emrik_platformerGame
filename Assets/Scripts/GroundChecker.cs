﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public int isGrounded;
    
    //Kollar om "GroundChecker" är på marken
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground") isGrounded++;
    }

    //Kollar När "GroundChecker" Lämnar marken
    //"OnTriggerExit" händer när något lämnar en "Collider"
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground") isGrounded--;
    }
}