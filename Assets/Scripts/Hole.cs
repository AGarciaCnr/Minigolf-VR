using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private static string tag_pelota = "pelota";
    public GameObject next_hoyo;
    public GameObject pelota;
    public GameObject next_escenario;

    public bool pseudoHoyo = false;
    public bool isHole = false;


    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag_pelota)
        {
            Debug.Log("HOYO!!!");

            if(!pseudoHoyo)
                isHole = true;


            next_escenario.SetActive(true);
            pelota.GetComponent<Transform>().position = next_hoyo.transform.position;
            pelota.GetComponent<Rigidbody>().velocity = Vector3.zero;


        }
    }
}