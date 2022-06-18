using UnityEngine.Events;

namespace GameEvents.UnityEvents
{
    [System.Serializable] public struct Void { }
    [System.Serializable] public class UnityVoidEvent : UnityEvent<Void> { }
}