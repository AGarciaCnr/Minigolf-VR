using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pelota")
        {
            counter++;
            Debug.Log(counter);


            //counter.GetComponent<UnityEngine.UI.Text>().text = ammo.ToString();
        }
    }
}
