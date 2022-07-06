using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Has been triggered by player");
        }
        

    }
}
