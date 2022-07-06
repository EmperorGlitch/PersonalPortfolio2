using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Player_Control_Test : NetworkBehaviour
{



    float verticalMovement;
    float horizontalMovement;

    Vector3 moveDirection;

    Rigidbody rb;

    public float rbDrag = 6f;
    public float moveSpeed = 1f;

    //player can move
    public bool CanMove = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
        ControlDrag();
    }

    public override void OnStartLocalPlayer()
    {


        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = new Vector3(0, 0, 0);
    }

    void MyInput()
    {
        if (!isServer) { return; }

        if (CanMove == true)
        {
            horizontalMovement = Input.GetAxisRaw("Horizontal");
            verticalMovement = Input.GetAxisRaw("Vertical");

            moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

        }
    }

    private void FixedUpdate()
    {
        movePlayer();
    }

    void movePlayer()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.VelocityChange);
    }

    void ControlDrag()
    {
        rb.drag = rbDrag;
    }
}
