using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnBarriers : MonoBehaviour
{
    public GameObject Lasers1, Lasers2, Lasers3, Lasers4, BarrierTriggers1, BarrierTriggers2, BarrierTriggers3, Body1, Body2, Body3, Body4;

    void FixedUpdate()
    {
        if (CheckWyvernsChildren.AllWyvernsDead == true && CheckHydrasChildren.AllHydrasDead == true)
        {
            Lasers1.SetActive(false);
            Lasers2.SetActive(false);
            Lasers3.SetActive(false);
            Lasers4.SetActive(false);
            BarrierTriggers1.SetActive(false);
            BarrierTriggers2.SetActive(false);
            BarrierTriggers3.SetActive(false);
            Body1.GetComponent<MeshCollider>().enabled = false;
            Body2.GetComponent<MeshCollider>().enabled = false;
            Body3.GetComponent<MeshCollider>().enabled = false;
            Body4.GetComponent<MeshCollider>().enabled = false;
        }
    }
}
