using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponentInChildren<HingeJoint>().angle == 60)
        {
            Debug.Log("Palanca Max");
        }
        else if (gameObject.GetComponentInChildren<HingeJoint>().angle == -60)
        {
            Debug.Log("Palanca Min");
        }
    }
}