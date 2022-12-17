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
            this.transform.position = ((GameManager)GameManager.Instance).personaje.transform.position + new Vector3(0.5f, 0, 0.5f);
            this.transform.rotation = Quaternion.Euler(new Vector3(-75, 0, 90));
        }
    }

    public void IsDroped(bool dp)
    {
        Debug.Log("Droped");

        
        droped = dp;
    }
}
