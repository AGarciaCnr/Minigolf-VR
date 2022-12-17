using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaloPunta : MonoBehaviour
{

    public GameObject punta, newPunta;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.Equals(punta))
        {
            Debug.Log("funciona");
            newPunta.SetActive(true);
            punta.SetActive(false);

        }
    }

}