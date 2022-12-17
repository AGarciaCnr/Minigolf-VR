using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton
{
    public int totalScore = 0;

    private int ballCounter, holeCounter;

    private int holeReward = 100;


    [SerializeField]
    private GameObject _twoHandsGrab;

    [SerializeField]
    private GameObject _personaje;

    [SerializeField]
    private GameObject _palo;

    [SerializeField]
    private GameObject _hole;

    [SerializeField]
    private GameObject _ball;

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

    public GameObject palo
    {
        get
        {
            return _palo;
        }
    }

    public GameObject hole
    {
        get
        {
            return _hole;
        }
    }

    public GameObject ball
    {
        get
        {
            return _ball;
        }
    }

    public void Update()
    {
        if (hole.GetComponent<Hole>().isHole)
        {
            ballCounter = palo.GetComponent<BallHit>().counter;
            totalScore += holeReward - ballCounter * 2;
            holeCounter++;
            palo.GetComponent<BallHit>().counter = 0;
        }
    }
}