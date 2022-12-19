using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;

public class Palo : MonoBehaviour
{
    public bool droped;
    private bool colocado = false;
    private float timer = 0.0f;
    private bool soltado = true;

    void Start()
    {
        
    }

    private void Update()
    {
        if (droped && ((GameManager)GameManager.Instance).twoHandsGrab.GetComponent<TwoHandsGrab>().twoHandsGrabbed == 0)
        {
            if (soltado)
            {
                timer = 0.0f;
                soltado = false;
                //gameObject.GetComponent<Rigidbody>().useGravity = true;
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                gameObject.GetComponent <Rigidbody>().useGravity = true;
            }
            timer += Time.deltaTime;

            if (!colocado && timer > 2.0f)
            {
                this.transform.parent = ((GameManager)GameManager.Instance).personaje.transform;
                this.transform.position = ((GameManager)GameManager.Instance).personaje.transform.GetChild(1).transform.position;
                this.transform.rotation = Quaternion.Euler(new Vector3(-75, 0, 90));
                colocado = true;
                //gameObject.GetComponent<Rigidbody>().useGravity= false;
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        else
        {
            this.transform.SetParent(null);
            colocado = false;
            soltado = true;
        }
    }
    
    public void IsDroped(bool dp)
    {
        Debug.Log("Droped");
        droped = dp;
    }

}