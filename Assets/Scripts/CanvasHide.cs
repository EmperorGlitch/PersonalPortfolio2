using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CanvasHide : NetworkBehaviour
{

    public Canvas can1;  //first player canvas
    public Canvas can2;   // second palyer canvas



    // Start is called before the first frame update
    void Start()
    {
       // can1.enabled = false;
       // can2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isServer)
        {
            can1.enabled = true; //show the 1st player canvas
            can2.enabled = false; // hide the 2nd player canvas

        }

        if (!isClient)
        {
            can1.enabled = false; // hide 1st player canvas
            can2.enabled = true;    // show 2nd player canvas

        }
    }
}
