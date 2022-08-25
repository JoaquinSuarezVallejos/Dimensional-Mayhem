using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNG
{

    /// <summary>
    /// Attach this Component to any EmeraldAISystem object you wish to deal damage to.
    /// </summary>
    public class EmeraldAIDamageable : Damageable
    {

        public override void DealDamage(float damageAmount, Vector3? hitPosition = null, Vector3? hitNormal = null, bool reactToHit = true, GameObject sender = null, GameObject receiver = null)
        {
            // Limb Damage
            if (GetComponent<EmeraldAI.LocationBasedDamageArea>() != null)
            {
                GetComponent<EmeraldAI.LocationBasedDamageArea>().DamageArea((int)damageAmount, EmeraldAI.EmeraldAISystem.TargetType.Player, null, 400);
            }
            // Core Damage
            else if (GetComponent<EmeraldAI.EmeraldAISystem>() != null)
            {
                GetComponent<EmeraldAI.EmeraldAISystem>().Damage((int)damageAmount, EmeraldAI.EmeraldAISystem.TargetType.Player, null, 400);
            }
        }
    }
}

