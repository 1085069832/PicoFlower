using Leap.Unity.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeapGrab : InteractionBehaviour
{
    protected override void OnGraspBegin()
    {
        base.OnGraspBegin();
        GetComponent<GrabbableObject>().OnGrab();
    }

}
