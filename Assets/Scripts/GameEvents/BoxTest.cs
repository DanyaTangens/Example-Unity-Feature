using UnityEngine;

namespace GameEvents
{
    public class BoxTest : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        public void PressedSpacebar()
        {
            Debug.Log("You pressed the spacebar!");
        }
    
        public void PressedE()
        {
            Debug.Log("You pressed E key!");
        }

        public void ChangeColorToGreen()
        {
            _spriteRenderer.color = Color.green;
        }
        
        public void ChangeColorToBlue()
        {
            _spriteRenderer.color = Color.blue;
        }
    }   
}
