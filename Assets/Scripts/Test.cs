using Mirror;
using UnityEngine;

namespace QuickStart
{
    public class Test : NetworkBehaviour
    {

        float verticalMovement;
        float horizontalMovement;

        Vector3 moveDirection;

        Rigidbody rb;

        public float rbDrag = 6f;
        public float moveSpeed = 1f;


        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
        }


        public override void OnStartLocalPlayer()
        {
            Camera.main.transform.SetParent(transform);
            Camera.main.transform.localPosition = new Vector3(0, 0, 0);
        }

        void Update()
        {
            if (!isServer) { return; }

            float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * 110.0f;
            float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 4f;

            // horizontalMovement = Input.GetAxisRaw("Horizontal");
            // verticalMovement = Input.GetAxisRaw("Vertical");

            // moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

            transform.Rotate(0, moveX, 0);
            transform.Translate(0, 0, moveZ);
        }
    }
}
