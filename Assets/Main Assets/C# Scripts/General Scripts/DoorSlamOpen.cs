using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlamOpen : MonoBehaviour
{
    public GameObject TriggerDoorPlate1, WoodenDoorSlam, WyvernsDoorSlamSet, HydrasDoorSlamSet;
    public AudioSource doorOpen;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FloorProximity")
        {
            TriggerDoorPlate1.SetActive(false);
            WyvernsDoorSlamSet.SetActive(true);
            HydrasDoorSlamSet.SetActive(true);

            WoodenDoorSlam.GetComponent<Animator>().Play("DoorSlamOpen");
            doorOpen.Play();
        }
    }
}
