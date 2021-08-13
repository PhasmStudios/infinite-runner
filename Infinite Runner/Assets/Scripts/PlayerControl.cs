using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //variables
    public int horPosition = 0;
    public float strafeSpeed, jumpHeight = 2f;
    public bool touchingGround = true;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            //sets the left and right limit
            horPosition = Strafe(horPosition);
            //jump function
            touchingGround = Jump(touchingGround, jumpHeight);
        }
    }

    //moves the player left and right
    private int Strafe(int pos)
    {
        //left
        if (Input.GetKeyDown(KeyCode.LeftArrow) && pos != -1)
        {
            transform.Translate(Vector3.left * 1.25f);
            pos--;
        }
        //right
        else if (Input.GetKeyDown(KeyCode.RightArrow) && pos != 1)
        {
            transform.Translate(Vector3.right * 1.25f);
            pos++;
        }
        //not
        return pos;
    }

    //moves player in air
    private bool Jump(bool touching, float height)
    {
        if (touching && Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * height);
        }
        return false;
    }

    //collision manager
    private void OnCollisionEnter(Collision collision)
    {
        //touching ground?
        if (collision.collider.gameObject.layer == 6)
        {
            touchingGround = true;
        }
    }
}
