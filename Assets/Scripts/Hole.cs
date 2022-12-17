using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private static string tag_pelota = "pelota";

    public bool isHole = false;

    public GameObject next_hoyo;
    public GameObject pelota;


    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag_pelota)
        {
            Debug.Log("HOYO!!!");
            isHole = true;
            pelota.GetComponent<Transform>().position = next_hoyo.transform.position;
            pelota.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }
}