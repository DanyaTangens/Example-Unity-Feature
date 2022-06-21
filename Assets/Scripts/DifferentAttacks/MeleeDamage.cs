using UnityEngine;

namespace DifferentAttacks
{
    [CreateAssetMenu(fileName = "New Melee Damage", menuName = "Different Attack Type/Melee Damage")]
    public class MeleeDamage: DoDamage
    {
        public override void Damage(int damage, Transform point, LayerMask mask)
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(point.position, 2f, mask);
            Debug.Log(hitEnemies.Length);
            foreach (Collider2D enemy in hitEnemies)
            {
                if (enemy.TryGetComponent(out SpriteRenderer spriteRenderer))
                {
                    spriteRenderer.color = Color.blue;
                }
            }
        }
    }
}