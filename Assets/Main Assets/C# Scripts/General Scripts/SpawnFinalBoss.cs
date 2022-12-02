using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFinalBoss : MonoBehaviour
{
    public GameObject finalBoss, wallFinalBoss1, wallFinalBoss2;

    void FixedUpdate()
    {
        if (CheckWyverns2.AllWyvernsDead2 == true && CheckHydras2.AllHydrasDead2 == true && CheckGoblinsChildren.AllGoblinsDead == true)
        {
            finalBoss.SetActive(true);
            wallFinalBoss1.SetActive(true);
            wallFinalBoss2.SetActive(true);
        }
    }
}
