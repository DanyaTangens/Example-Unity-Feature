using DanyaTangens.GameEvents.Events;
using GameEvents.Element;
using GameEvents.UnityEvents;

namespace DanyaTangens.GameEvents.Listeners
{
    public class CustomDataListener : BaseGameEventListener<CustomData, CustomDataEvent, UnityCustomDataEvent> { }
}