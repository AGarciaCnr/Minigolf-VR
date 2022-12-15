using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFall : MonoBehaviour
{
    private bool climbing = false;
    private CharacterController characterController;


    void Start()
    {
        ClimbProvider.ClimbActive += Climb;
        ClimbProvider.ClimbInactive += UnClimb;
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!characterController.isGrounded && !climbing)
        {
            characterController.SimpleMove(Vector3.zero);
        }
    }

    private void Climb()
    {
        climbing = true;
    }

    private void UnClimb()
    {
        climbing = false;
    }
}
