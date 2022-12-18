using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherDianas : MonoBehaviour
{
    public GameObject[] dianas;

    public int dianasRestantes;

    void Start()
    {
        dianasRestantes = dianas.Length;
    }
    
    void Update()
    {
        if (dianasRestantes == 0)
        {
            Debug.Log("Has ganado");
        }
    }
}
