using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class ClimbProvider : MonoBehaviour
{
    public static event Action ClimbActive;
    public static event Action ClimbInactive;

    public GameObject RightHand;
    public GameObject LeftHand;

    private bool leftActive = false;
    private bool rightActive = false;

    public InputActionProperty velocityRight;
    public InputActionProperty velocityLeft;

    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        ClimbInteractor.ClimbActivated += HandActivated;
        ClimbInteractor.ClimbDeactivated += HandDeactivated;
    }

    private void HandActivated(string handName)
    {
        if (handName == RightHand.name)
        {
            leftActive = false;
            rightActive = true;
        }
        else if (handName == LeftHand.name)
        {
            leftActive = true;
            rightActive = false;
        }

        ClimbActive?.Invoke();
    }

    private void HandDeactivated(string handName)
    {
        if (handName == RightHand.name)
        {
            rightActive = false;
        }
        else if (handName == LeftHand.name)
        {
            leftActive = false;
        }

        if (!leftActive && !rightActive)
            ClimbInactive?.Invoke();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (leftActive || rightActive)
        {
            Climb();
        }
    }

    private void Climb()
    {
        Vector3 velocity = leftActive ? velocityLeft.action.ReadValue<Vector3>() : velocityRight.action.ReadValue<Vector3>();
        characterController.Move(characterController.transform.rotation * -velocity * Time.fixedDeltaTime);
    }
}
