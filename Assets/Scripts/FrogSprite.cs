using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogSprite : MonoBehaviour
{

    public GroundChecker groundCheck;
    public Sprite jump;
    public Sprite onGround;

    void Update()
    {
        if (groundCheck.IsGrounded > 0)
        {
            //Om "IsGrounded" är större än 0 så blir spriten "onGround" som man har valt i Unity.
            this.gameObject.GetComponent<SpriteRenderer>().sprite = onGround;
        }
        else
        {
            //Om "IsGrounded" inte är större än 0 så blir spriten "jump" som man har valt i Unity.
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jump;
        }
    }
}
