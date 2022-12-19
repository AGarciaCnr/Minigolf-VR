using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoTrigger : MonoBehaviour
{
    public GameObject escenarioDisparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        escenarioDisparo.SetActive(true);
    }
}
