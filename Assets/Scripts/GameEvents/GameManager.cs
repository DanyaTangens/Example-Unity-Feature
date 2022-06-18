using DanyaTangens.GameEvents.Events;
using GameEvents.Element;
using UnityEngine;

namespace GameEvents
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private VoidEvent _onVoidEvent;
        [SerializeField] private StringEvent _onStringEvent;
        [SerializeField] private IntEvent _onIntEvent;
        [SerializeField] private CustomDataEvent _onCustomDataEvent;

        public void VoidEvent()
        {
            _onVoidEvent.Raise();
        }

        public void StringEvent()
        {
            _onStringEvent.Raise(GenerateRandomString());
        }

        public void IntEvent()
        {
            _onIntEvent.Raise(GenerateRandomNumber());
        }

        public void CustomDataEvent()
        {
            var customData = new CustomData(
                GenerateRandomNumber(),
                GenerateRandomString(),
                GenerateRandomNumber()
                );
            
            _onCustomDataEvent.Raise(customData);
        }

        private int GenerateRandomNumber()
        {
            return Random.Range(1, 1001);
        }
        
        private string GenerateRandomString()
        {
            var result = "";
            
            var allWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            for (int j = 0; j < 16; j++)
            {
                var randomPosition = Random.Range(0, allWords.Length);
                var tmpWord = allWords.Substring(randomPosition, 1);
                result += tmpWord;
            }

            return result;
        }
    }
}