using UnityEngine;

namespace Assets.Scripts.Battle.Damage.DealerEffects
{
    public class CameraShakerOnSpaceDown : MonoBehaviour, IEventListener<SpaceBarDownEvents>
    {
        [SerializeField] private CameraShakeData shakeEffect;

        public void Notify(SpaceBarDownEvents e)
        {
            if (e == SpaceBarDownEvents.OnSpaceBarDown)
                CameraShaker.Instance.Shake(shakeEffect);
        }
    }
}
