using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public Color originalColor;
    private void Start()
    {
        originalColor = GetComponent<MeshRenderer>().material.color;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit"; 
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = originalColor;
    }
}
