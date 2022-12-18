using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private GameObject pelota;
    public InputActionProperty buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed.action.WasPressedThisFrame() && ((GameManager)GameManager.Instance).twoHandsGrab.GetComponent<TwoHandsGrab>().twoHandsGrabbed == 0)
            teleportToBall();

    }

    void teleportToBall()
    {
        gameObject.transform.position = pelota.transform.position + transform.up * 0.9f;
        //transform.position = Vector3.MoveTowards(transform.position, pelota.transform.position, 5f * Time.deltaTime);
    }
}
