using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerTransform;
    [SerializeField]
    private Transform TeleportGoalOne;
    [SerializeField]
    private Transform TeleportGoalTwo;
    [SerializeField]
    private Transform TeleportGoalThree;

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

    void OnTriggerEnter()
    {
        Debug.Log("Hit " + name);
        PlayerTransform.transform.position = new Vector3(TeleportGoalOne.position.x, TeleportGoalOne.position.y + 5, TeleportGoalOne.position.z - 5);
 }
}
