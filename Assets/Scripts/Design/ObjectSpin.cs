using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    {
        _rotation = Vector3.up;
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
