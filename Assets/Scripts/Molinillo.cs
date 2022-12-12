using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molinillo : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed = 100;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * rotationSpeed));
    }
}
