using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float xAngle = 1;
    [SerializeField] float yAngle = 1;
    [SerializeField] float zAngle = 1;

    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
