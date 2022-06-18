using DanyaTangens.GameEvents.Events;
using UnityEngine;
using UnityEngine.Events;

namespace DanyaTangens.GameEvents
{
    [System.Serializable]
    public class ResponseEvent<T, E, UER> where E : BaseGameEvent<T> where UER : UnityEvent<T>
    {
        [SerializeField] public E custonEvent;
        [SerializeField] private UER onPickedResponse;

        public UER OnPickedResponse => onPickedResponse;
    }
}