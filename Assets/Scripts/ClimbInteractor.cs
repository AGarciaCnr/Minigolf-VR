using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbInteractor : XRDirectInteractor
{
    private static string tag_escalera = "escalera";
    private string controllerName;

    public static event Action<string> ClimbActivated;
    public static event Action<string> ClimbDeactivated;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        controllerName = gameObject.name;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        if (args.interactableObject.transform.CompareTag(tag_escalera))
        {
            ClimbActivated.Invoke(controllerName);
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);

        ClimbDeactivated.Invoke(controllerName);
    }
}
