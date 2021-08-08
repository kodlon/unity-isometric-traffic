using UnityEngine;

namespace Roads
{
    public class DamagedRoad : MonoBehaviour, IRoad
    {
        public void Click()
        {
            return;
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            return currentCarSpeed / 2f;
        }
    }
}
