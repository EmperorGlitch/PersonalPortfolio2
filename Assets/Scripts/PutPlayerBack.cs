using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutPlayerBack : MonoBehaviour
{
    [SerializeField]
    private GameObject respawnPoint;
    [SerializeField]
    private GameObject PlayerTransform;

    private void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            PlayerTransform = GameObject.FindGameObjectWithTag("Player");
        }


        // Reference the Player's Transform Component
    }

    private void OnTriggerEnter()
    {
        PlayerTransform.transform.position = respawnPoint.transform.position;
    }
}
