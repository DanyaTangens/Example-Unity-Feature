using System;
using UnityEngine;

namespace DifferentAttacks
{
    public class PlayerAttack: MonoBehaviour
    {
        public int damage = 1;
        public DoDamage contextDamage;
        public Transform point;
        public LayerMask targetMask;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TryDoDamage();
            }
        }

        public void TryDoDamage()
        {
            contextDamage.Damage(damage, point, targetMask);
        }
        
#if UNITY_EDITOR
        private void OnDrawGizmosSelected()
        {
            if (point == null)
                return;
            Gizmos.DrawWireSphere(point.position, 2f);
        }
#endif
    }
}