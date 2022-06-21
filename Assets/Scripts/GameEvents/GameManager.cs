using GameEvents.Events;
using UnityEngine;

namespace GameEvents
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private VoidEvent _getKeyDownSpaceEvent;
        [SerializeField] private VoidEvent _getKeyDownEEvent;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _getKeyDownSpaceEvent.Raise();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                _getKeyDownEEvent.Raise();
            }
        }
    }
}
