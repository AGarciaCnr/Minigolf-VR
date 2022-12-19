using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    private GameObject[] _hole;

    [SerializeField]
    private GameObject _ball;

    [SerializeField]
    private GameObject _reloj;

    [SerializeField]
    private GameObject _titulo;

    [SerializeField]
    private GameObject _final;

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

    public GameObject[] hole
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

    public GameObject reloj
    {
        get
        {
            return _reloj;
        }
    }

    public GameObject titulo
    {
        get
        {
            return _titulo;
        }
    }

    public GameObject final
    {
        get
        {
            return _final;
        }
    }

    public void Start()
    {
        holeCounter = 0;
        ballCounter = 0;
    }

    public void Update()
    {
        if (hole[holeCounter].GetComponent<Hole>().isHole)
        {
            ballCounter = palo.GetComponent<BallHit>().counter;
            totalScore += holeReward - ballCounter * 2;
            holeCounter++;
            palo.GetComponent<BallHit>().counter = 0;
        }
        
        TextMeshProUGUI textReloj = reloj.GetComponentInChildren<TextMeshProUGUI>();
        textReloj.SetText("Golpes:\n" + palo.GetComponent<BallHit>().counter.ToString() + "\n\nPuntuación:\n" + totalScore.ToString());

        if (hole[0].GetComponent<Hole>().isHole)
        {
            titulo.SetActive(false);
        }

        if (hole[hole.Length - 1].GetComponent<Hole>().isHole)
        {
            final.SetActive(true);
            TextMeshProUGUI finalText = final.GetComponentInChildren<TextMeshProUGUI>();
            finalText.SetText("Tu puntuación final ha sido: " + totalScore.ToString());
        }
    }
}