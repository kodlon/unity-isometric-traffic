using DG.Tweening;
using UnityEngine;

namespace Roads
{
    public class FinishRoad : MonoBehaviour, IRoad
    {
        public void Click()
        {
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            carTransform.DOMove( carTransform.position - (carTransform.forward / 2), 1f);
            return 0f;
        }
    }
}
