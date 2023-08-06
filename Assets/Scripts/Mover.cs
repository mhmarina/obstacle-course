using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }
    void printInstructions() {
        Debug.Log("Welcome to Obstacle Course!");
        Debug.Log("Move your player with WASD or Arrow Keys.");
        Debug.Log("Don't hit the walls.");
    }
    void movePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xVal, 0, zVal);
    }
}
