using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 1.0f;
    public float sensitivityVert = 1.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;

    //fixed mouse
    Vector3 euler;

    private float mouseX;
    private float mouseY;

    private float sensitivityMouse = 200f;

    public Transform Player;

    public bool isLooking = true;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        if (isLooking)
        {

            mouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;

            
            //Player.Rotate(mouseX * new Vector3(0, 1, 0));

            //transform.Rotate(-mouseY * new Vector3(1, 0, 0));

            Player.Rotate(mouseX * new Vector3(0, 1, 0));

            transform.Rotate(-mouseY * new Vector3(1, 0, 0));


            //euler.y = Mathf.Clamp(euler.y, 80.0f, -70.0f);
            //transform.localEulerAngles = euler;
        }
    }
}
