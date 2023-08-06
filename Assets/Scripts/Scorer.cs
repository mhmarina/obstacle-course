using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int timesBumped = -1;
    private void OnCollisionEnter(Collision collision)
    {
            timesBumped++;
            Debug.Log("You've bumped into the wall " + timesBumped + " times");
    }
}
