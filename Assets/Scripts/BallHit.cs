using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    public int counter = 0;

    [SerializeField]
    private GameObject ballCounter;

    // Start is called before the first frame update
    void Start()
    {
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
            //Debug.Log(counter);
            ballCounter.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
            //ballCounter.GetComponent<TextMesh>().text = counter.ToString();
        }
    }
}
