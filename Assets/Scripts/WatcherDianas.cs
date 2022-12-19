using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatcherDianas : MonoBehaviour
{
    public GameObject[] dianas;

    public int dianasRestantes;

    public GameObject restoDelNivel;
    public GameObject quitarMuro;

    void Start()
    {
        dianasRestantes = dianas.Length;
    }
    
    void Update()
    {
        if (dianasRestantes == 0)
        {
            Debug.Log("Has ganado");
            restoDelNivel.SetActive(true);
            quitarMuro.SetActive(false);
        }
    }
}
