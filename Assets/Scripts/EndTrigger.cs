using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject finishCanvas;

    void OnTriggerEnter()
    {
        finishCanvas.SetActive(true);
    }
}
