using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    public float healthPoints = 20;
    public float speed = 10f;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            movePlayer();
        }
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Goal" && healthPoints >= 0) {
            healthPoints--;
            Debug.Log("Your current health is " + healthPoints);
            if (healthPoints == 0) {
                gameOver = true;
                Debug.Log("Game Over");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
