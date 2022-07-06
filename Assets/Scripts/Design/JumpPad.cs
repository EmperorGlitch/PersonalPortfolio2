using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public int jumpForce;
    public int pushForce;
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("player is on jump pad");
        player.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        player.GetComponent<Rigidbody>().AddForce(Vector3.forward * pushForce);
    }
}

