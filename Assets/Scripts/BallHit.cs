using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    public int counter = 0;

    [SerializeField]
    private float velocityMultiplayer = 2.5f;

    private float timer = 0.0f;

    [SerializeField]
    private GameObject ballCounter;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {        

        if (collision.gameObject.tag == "pelota" && timer >= 0.5f)
        {
            Debug.Log(timer);
            timer = 0.0f;

            ((GameManager)GameManager.Instance).ball.GetComponent<Rigidbody>().velocity = this.GetComponent<Rigidbody>().velocity * velocityMultiplayer;

            counter++;
            Debug.Log(counter);
            ballCounter.GetComponent<UnityEngine.UI.Text>().text = counter.ToString();
            //ballCounter.GetComponent<TextMesh>().text = counter.ToString();
        }
    }
}
