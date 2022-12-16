using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton
{
    [SerializeField]
    private GameObject _twoHandsGrab;

    [SerializeField]
    private GameObject _personaje;

    public GameObject twoHandsGrab
    {
        get
        {
            return _twoHandsGrab;
        }
    }

    public GameObject personaje
    {
        get
        {
            return _personaje;
        }
    }
}