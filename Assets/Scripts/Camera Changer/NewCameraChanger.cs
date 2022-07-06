using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NewCameraChanger : NetworkBehaviour
{

    public Camera cam1;
    public Camera cam2;


    // Start is called before the first frame update
    void Start()
    {

        cam2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!isServer)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }

        if (!isClient)
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
    }
}