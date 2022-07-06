using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class OldCameraControl : NetworkBehaviour
{

    private float mouseX;
    private float mouseY;

    private float sensitivityMouse = 200f;

    public Transform Player;

    public bool isLooking = true;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (isLooking)
        {

            mouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;

            Player.Rotate(mouseX * new Vector3(0, 1, 0));

            transform.Rotate(-mouseY * new Vector3(1, 0, 0));

        }
    }
}
