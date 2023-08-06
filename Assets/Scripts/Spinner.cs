using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    Transform transform;
    public float yRotation = 1;
    public float rotationSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        yRotation = 1 * rotationSpeed;
        transform.Rotate(0, yRotation , 0);
    }
}
