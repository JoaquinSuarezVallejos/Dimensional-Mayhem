using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDone : MonoBehaviour
{
    //Int Damage
    int totalDamage = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //detect if enemy recieves damage.
        //send dmg amount to this script in empty and run AddDamage function.
    }

    public void AddDamage(int damageAmount)
    {
        totalDamage += damageAmount;
    }
}
