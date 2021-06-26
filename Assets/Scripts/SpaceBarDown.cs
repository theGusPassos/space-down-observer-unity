using UnityEngine;

namespace Assets.Scripts
{
    public enum SpaceBarDownEvents
    {
        OnSpaceBarDown
    }

    public class SpaceBarDown : EventSender<SpaceBarDownEvents>
    {
        private void Awake()
        {
            Listeners.AddRange(GetComponentsInChildren<IEventListener<SpaceBarDownEvents>>());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                NotifyListeners(SpaceBarDownEvents.OnSpaceBarDown);
        }
    }
}
