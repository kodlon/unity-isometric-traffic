using UnityEngine;

namespace Roads
{
    public class FinishRoad : MonoBehaviour, IRoad
    {
        public void Click()
        {
            return;
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            return 0f;
        }
    }
}
