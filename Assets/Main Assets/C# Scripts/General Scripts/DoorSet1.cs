using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSet1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FloorProximity")
        {
           /* TriggerDoorPlate2.SetActive(false);
            TriggerDoorPlate3.SetActive(false);
            TriggerDoorPlate4.SetActive(false);
            DoorBlockBarrierTrigger.SetActive(true);

            WoodenDoorSlam.GetComponent<Animator>().Play("DoorSlamClose");
            doorSlam.Play(); */
        }
    }
}
