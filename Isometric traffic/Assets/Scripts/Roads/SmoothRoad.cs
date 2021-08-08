using UnityEngine;

namespace Roads
{
    public class SmoothRoad : MonoBehaviour, IRoad
    {
        public void Click()
        {
            return;
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            return startCarSpeed;
        }
    }
}
