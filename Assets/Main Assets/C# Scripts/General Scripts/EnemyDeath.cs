using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    bool isDead = false;
    [SerializeField] float cooldown = 2;
    KillCounter killCounter;

    private void Start()
    {
        killCounter = GameObject.Find("ENEMY KILLS COUNTER").GetComponent<KillCounter>();
    }

    private void Update()
    {
        if (isDead && cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }    
        if (cooldown <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        isDead = true;
        if (cooldown <= 0)
        {
            Destroy(gameObject);
            killCounter.AddKill();
        }
    }
}
