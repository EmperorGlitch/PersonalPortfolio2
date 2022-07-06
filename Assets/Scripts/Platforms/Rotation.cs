using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] private float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 360 * speed * Time.deltaTime, 0);
    }
}
