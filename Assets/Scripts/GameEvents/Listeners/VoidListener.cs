using GameEvents.Events;
using GameEvents.UnityEvents;

namespace GameEvents.Listeners
{
    public class VoidListener : BaseGameEventListener<Void, VoidEvent, UnityVoidEvent> { }
}