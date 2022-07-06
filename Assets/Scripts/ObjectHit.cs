using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    bool isHitted = false;

    private void OnCollisionEnter(Collision other) {


        if (!isHitted && other.gameObject.tag == "Player") {
            Debug.Log("Hitted :" + this);
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hitted";
        }
    }
}
