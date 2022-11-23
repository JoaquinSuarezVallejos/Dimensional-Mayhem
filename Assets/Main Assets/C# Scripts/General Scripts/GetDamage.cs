using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    EmeraldAIDamageable damageableScript;
    float totalLife;
    float damageDone;
    float currentLife;

    // Start is called before the first frame update
    void Start()
    {
        damageableScript = gameObject.GetComponent<EmeraldAIDamageable>();
        totalLife = damageableScript.Health;
    }

    void Update()
    {
        currentLife = damageableScript.Health;
        Debug.Log(currentLife);
    }

    public void GetDamageDone()
    {
        damageDone += totalLife - currentLife;
    }
}
