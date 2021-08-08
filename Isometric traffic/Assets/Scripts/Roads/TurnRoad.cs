using UnityEngine;

namespace Roads
{
    public class TurnRoad : MonoBehaviour, IRoad
    {
        Ray rayRight;
        Ray rayBack;
        bool isConnected = false;


        private void Start()
        {
            CheckRoadOnConnection();
        }

        public void Click()
        {
            if (!StartLevel.isLevelStarted)
            {
                this.transform.Rotate(0, -90, 0);
                CheckRoadOnConnection();
            }
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            if (isConnected)
                carTransform.Rotate(0, -90, 0);
            return startCarSpeed;
        }

        private void CheckRoadOnConnection()
        {
            RayInitializer();

            RaycastHit hit;
            isConnected = Physics.Raycast(rayRight, out hit) & hit.collider != null
                                                             & Physics.Raycast(rayBack, out hit) & hit.collider != null;
        }

        private void RayInitializer()
        {
            rayRight = new Ray(transform.position, transform.TransformDirection(Vector3.right));
            rayBack = new Ray(transform.position, transform.TransformDirection(Vector3.back));
        }

        private void OnDrawGizmos()
        {
            CheckRoadOnConnection();

            Gizmos.color = isConnected ? Color.green : Color.red;

            Gizmos.DrawRay(rayRight.origin, rayRight.direction);
            Gizmos.DrawRay(rayBack.origin, rayBack.direction);
        }
    }
}
