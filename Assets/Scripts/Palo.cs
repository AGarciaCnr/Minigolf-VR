using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.XR.LegacyInputHelpers;
using UnityEngine;

public class Palo : MonoBehaviour
{
    public bool droped;
    private bool colocado = false;

    void Start()
    {
        
    }

    private void Update()
    {
        if (droped && ((GameManager)GameManager.Instance).twoHandsGrab.GetComponent<TwoHandsGrab>().twoHandsGrabbed == 0)
        {
            if (!colocado)
            {
                this.transform.parent = ((GameManager)GameManager.Instance).personaje.transform;
                this.transform.position = ((GameManager)GameManager.Instance).personaje.transform.GetChild(1).transform.position;
                this.transform.rotation = Quaternion.Euler(new Vector3(-75, 0, 90));
                colocado = true;
            }
        }
        else
        {
            this.transform.SetParent(null);
            colocado = false;
        }
    }
    
    public void IsDroped(bool dp)
    {
        Debug.Log("Droped");
        droped = dp;
    }

}