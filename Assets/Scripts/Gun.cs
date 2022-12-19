using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject proyectile;
    
    private GameObject counter;

    private int maxAmmo;
    private int ammo = 0;

    void Start()
    {
        maxAmmo = 30;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("olawenas");
        if (other.gameObject.tag == "cargador")
        {
            recargar();
            Destroy(other.gameObject);
            
        }
    }

    public void disparar()
    {
        if (ammo == 0)
            return;

        GameObject x = Object.Instantiate<GameObject>(this.proyectile);

        x.transform.position = this.transform.position + this.transform.forward * 0.38f + this.transform.up * 0.045f;
        x.transform.rotation = this.transform.rotation;
        x.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000f);

        ammo--;

        counter.GetComponent<UnityEngine.UI.Text>().text = ammo.ToString();
    }

    public void recargar()
    {
        ammo = maxAmmo;
    }
}
