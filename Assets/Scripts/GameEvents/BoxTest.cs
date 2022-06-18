using UnityEngine;
using GameEvents.Element;

namespace GameEvents
{
    public class BoxTest : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;

        public void VoidEvent()
        {
            Debug.Log("You activeted Void Event!");
            _spriteRenderer.color = Color.green;
        }

        public void StringEvent(string text)
        {
            Debug.Log($"You activeted String Event! \n Your random string: {text}");
            _spriteRenderer.color = Color.blue;
        }

        public void IntEvent(int number)
        {
            Debug.Log($"You activeted Int Event! \n Your random number: {number}");
            _spriteRenderer.color = Color.yellow;
        }

        public void CustonDataEvent(CustomData customData)
        {
            Debug.Log(
                $"You activeted CustonData Event! \n " +
                $"CustomData: ID: {customData.ID} Description: {customData.Description} Cost: {customData.Cost}"
                );
            
            _spriteRenderer.color = Color.red;
        }
    }
}