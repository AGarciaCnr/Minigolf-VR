using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private static string tag_pelota = "pelota";

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag_pelota)
        {
            Debug.Log("HOYO!!!");
            Destroy(other.gameObject);
        }
    }
}