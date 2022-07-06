using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DoorTrigger : NetworkBehaviour
{
    
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger= false;
    [SerializeField] private bool closeTrigger= false;
    [SerializeField] private string doorOpen = "DoorOpen";
    [SerializeField] private string doorClose = "DoorClose";
    // Start is called before the first frame update
    private void Start()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (openTrigger)
            {
                Debug.Log("open the door");
                myDoor.Play(doorOpen,0,0.0f);
                gameObject.SetActive(false);
            
            }
            else if (closeTrigger)
            {
                Debug.Log("Close the door");
                myDoor.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
              
            }
        }
    }

}
