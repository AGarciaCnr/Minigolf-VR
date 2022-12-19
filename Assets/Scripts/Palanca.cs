using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    public GameObject puerta1;
    public GameObject puerta2;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponentInChildren<HingeJoint>().angle > 59)
        {
            Debug.Log("Palanca Max");
            puerta1.transform.position = Vector3.MoveTowards(puerta1.transform.position, new Vector3(puerta1.transform.position.x, -3, puerta1.transform.position.z), Time.deltaTime * speed);
            puerta2.transform.position = Vector3.MoveTowards(puerta2.transform.position, new Vector3(puerta2.transform.position.x, 0, puerta1.transform.position.z), Time.deltaTime * speed);
        }
        else if (gameObject.GetComponentInChildren<HingeJoint>().angle < -59)
        {
            puerta1.transform.position = Vector3.MoveTowards(puerta1.transform.position, new Vector3(puerta1.transform.position.x, 0, puerta1.transform.position.z), Time.deltaTime * speed);
            puerta2.transform.position = Vector3.MoveTowards(puerta2.transform.position, new Vector3(puerta2.transform.position.x, -3, puerta1.transform.position.z), Time.deltaTime * speed);
            Debug.Log("Palanca Min");
        }
    }
}
