using Mirror;
using UnityEngine;

namespace QuickStart
{
    public class PlayerScript : NetworkBehaviour
    {

        float verticalMovement;
        float horizontalMovement;

        Vector3 moveDirection;

        Rigidbody rb;

        public float rbDrag = 6f;
        public float moveSpeed = 1f;
        public float jumpForce = 100f;
        public float pushForce = 100f;

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


            transform.Rotate(0, moveX, 0);
            transform.Translate(0, 0, moveZ);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Trap")
            {
                Debug.Log("player is on jump pad");
                rb.AddForce(Vector3.up * jumpForce);
                rb.AddForce(Vector3.forward * pushForce);
            }

        }
    }
}
