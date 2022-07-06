using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Jump : NetworkBehaviour
{
    //Change the numbers to change jumping or moving speed
    public float jumpSpeed = 6000f;

    Rigidbody rb;
    bool canJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Checking if the player is on the floor. If so, player can jump, else he cannot. 
    //The floor or any object from where you want the player to be able to jump must be tagged as "Ground"

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            canJump = false;
        }
    }

    void Update()
    {

        // Jumping Script. Player can jump only when canJump is true (means when the player is on the floor)
        if (Input.GetKey(KeyCode.Space) & canJump)
        {
            rb.AddForce(0f, jumpSpeed * Time.deltaTime, 0f);
        }

    }
}