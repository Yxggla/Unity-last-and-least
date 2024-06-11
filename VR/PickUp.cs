using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PickUp : Throwable
{
    public SteamVR_Action_Boolean GrabAction;
    // Start is called before the first frame update
    protected override void HandAttachedUpdate(Hand hand)
    {
        if (GrabAction.GetStateDown(SteamVR_Input_Sources.Any))
        {
            hand.DetachObject(this.gameObject,true);
        }
    }
}
