using GameEvents.Events;
using GameEvents.UnityEvents;

namespace GameEvents.Listeners
{
    public class IntListener : BaseGameEventListener<int, IntEvent, UnityIntEvent> { }
}