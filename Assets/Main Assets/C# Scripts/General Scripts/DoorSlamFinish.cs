using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlamFinish : MonoBehaviour
{
    public GameObject DoorBlockBarrierCollider, DoorBlockBarrierTrigger, WoodenDoorSlam;

    void FixedUpdate()
    {
        if (WyvernsDoorSlamSet.WyvernsSetDead == true && HydrasDoorSlamSet.HydrasSetDead == true)
        {
            DoorBlockBarrierTrigger.SetActive(false);
            DoorBlockBarrierCollider.SetActive(false);

            WoodenDoorSlam.GetComponent<Animator>().Play("DoorSlamOpen");
        }
    }
}
