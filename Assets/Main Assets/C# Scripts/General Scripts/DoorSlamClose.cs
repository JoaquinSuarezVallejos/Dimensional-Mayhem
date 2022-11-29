using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlamClose : MonoBehaviour
{
    public GameObject WoodenDoorSlam, TriggerDoorPlate2, TriggerDoorPlate3, TriggerDoorPlate4, DoorBlockBarrierTrigger;
    public AudioSource doorSlam;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FloorProximity")
        {
            TriggerDoorPlate2.SetActive(false);
            TriggerDoorPlate3.SetActive(false);
            TriggerDoorPlate4.SetActive(false);
            DoorBlockBarrierTrigger.SetActive(true);

            WoodenDoorSlam.GetComponent<Animator>().Play("DoorSlamClose");
            doorSlam.Play();
        }
    }
}
