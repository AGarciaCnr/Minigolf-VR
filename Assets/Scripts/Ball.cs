using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (GetComponent<Rigidbody>().velocity.magnitude > 0.1f)
        {
            Debug.DrawLine(transform.position, transform.position + GetComponent<Rigidbody>().velocity, Color.red);
            gameObject.layer = 12;
        }
        else if (GetComponent<Rigidbody>().velocity.magnitude < 0.1f)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.layer = 11;
        }
    }
}
