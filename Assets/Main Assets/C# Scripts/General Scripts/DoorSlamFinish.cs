using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlamFinish : MonoBehaviour
{
    public GameObject DoorBlockBarrierCollider, DoorBlockBarrierTrigger, WoodenDoorSlam;
    public AudioSource doorOpen;

    void FixedUpdate()
    {
        if (WyvernsDoorSlamSet.WyvernsSetDead == true && HydrasDoorSlamSet.HydrasSetDead == true)
        {
            DoorBlockBarrierTrigger.SetActive(false);
            DoorBlockBarrierCollider.SetActive(false);

            WoodenDoorSlam.GetComponent<Animator>().Play("DoorSlamOpen");
            doorOpen.Play();
        }
    }
}
