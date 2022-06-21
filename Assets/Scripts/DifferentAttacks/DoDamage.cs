using UnityEngine;

namespace DifferentAttacks
{
    public abstract class DoDamage: ScriptableObject
    {
        public abstract void Damage(int damage, Transform point, LayerMask mask);
    }
}