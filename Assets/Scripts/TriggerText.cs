using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public GameObject TextA;

    void Start()
    {
        TextA.gameObject.SetActive(false);
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        TextA.gameObject.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        TextA.gameObject.SetActive(false);
    }
}
