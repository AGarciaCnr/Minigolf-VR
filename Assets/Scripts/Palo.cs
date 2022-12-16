using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palo : MonoBehaviour
{
    public bool droped;
    
    
    void Start()
    {
        
    }

    private void Update()
    {
        if (droped && ((GameManager)GameManager.Instance).twoHandsGrab.GetComponent<TwoHandsGrab>().twoHandsGrabbed ==0)
        {
            this.transform.position = ((GameManager)GameManager.Instance).personaje.transform.position;
        }
    }

    public void IsDroped(bool dp)
    {
        Debug.Log("Droped");

        
        droped = dp;
    }
}
