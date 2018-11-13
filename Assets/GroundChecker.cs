﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{

    public bool IsGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGrounded = false;
    }
}