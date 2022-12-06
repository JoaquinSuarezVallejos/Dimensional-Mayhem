using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachineSpawn : MonoBehaviour
{
    public GameObject timeMachine, TMSpawnEffect;
    public AudioSource spawnBossEffect;

    void Update()
    {
        if (CheckWyverns2.AllWyvernsDead2 == true && CheckHydras2.AllHydrasDead2 == true && CheckGoblinsChildren.AllGoblinsDead == true)
        {
            timeMachine.SetActive(true);
            TMSpawnEffect.SetActive(true);
            spawnBossEffect.Play();
        }
    }
}
