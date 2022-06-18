using GameEvents.Element;
using UnityEngine;

namespace DanyaTangens.GameEvents.Events
{
    [CreateAssetMenu(fileName = "New CustomData Event", menuName = "Game Events/CustomData Event")]
    public class CustomDataEvent : BaseGameEvent<CustomData> { }
}