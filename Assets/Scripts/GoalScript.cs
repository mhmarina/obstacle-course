using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    public GameObject player;
    Mover mover;
    public bool gameWon = false;
    private void Start()
    {
        mover = player.GetComponent<Mover>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You won!");
        mover.gameOver = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
