using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = -1;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hitted")
        {
            score++;
            Debug.Log("Score: " + score);
        }
        
    }
}
