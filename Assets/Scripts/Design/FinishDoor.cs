using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishDoor : MonoBehaviour
{
    public GameObject finishCanvas;
    public GameObject mainCanvas;

    // Start is called before the first frame update
    public void DoSomethingWhenCollided()
    {
        mainCanvas.SetActive(false);
        finishCanvas.SetActive(true);
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("You win");
            DoSomethingWhenCollided();
        }



    }
}
