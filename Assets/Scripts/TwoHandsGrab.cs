using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandsGrab : XRGrabInteractable
{
    [SerializeField]
    private Transform _seconAttatchTransform;

    protected override void Awake()
    {
        base.Awake();
        selectMode = InteractableSelectMode.Multiple;
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        if (this.interactorsSelecting.Count == 1)
        {
            base.ProcessInteractable(updatePhase);
        }
        else if (this.interactorsSelecting.Count == 2 &&
                XRInteractionUpdateOrder.UpdatePhase.Dynamic == updatePhase)
        {
            //Debug.Log("Tho");
            ProccessTwoHandsGrab();
        }
    }

    private void ProccessTwoHandsGrab()
    {
        Transform firstAttatch = GetAttachTransform(null);
        Transform firstHand = interactorsSelecting[0].transform;
        Transform secondAttatch = _seconAttatchTransform;
        Transform secondHand = interactorsSelecting[1].transform;

        Vector3 directionBetweenHands = secondHand.position - firstHand.position;
        Vector3 directionBetweenAttatch = secondAttatch.position - firstAttatch.position;

        Quaternion rotationFromAttToForward = Quaternion.FromToRotation(directionBetweenAttatch, this.transform.forward);

        Quaternion targetRotation = rotationFromAttToForward * Quaternion.LookRotation(directionBetweenHands, firstHand.up);

        Vector3 worldDirectionFromHandleToBase = transform.position - firstAttatch.position;
        Vector3 localDirectionFromHandleToBase = transform.InverseTransformDirection(worldDirectionFromHandleToBase);

        Vector3 targetPosition = firstHand.position + targetRotation * localDirectionFromHandleToBase;

        transform.SetPositionAndRotation(targetPosition, targetRotation);
    }

    protected override void Grab()
    {
        if (interactorsSelecting.Count == 1)
        {
            base.Grab();
        }
    }

    protected override void Drop()
    {
        if (!isSelected)
        {
            base.Drop();
        }
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);
    }
}
