using UI.HUD;
using UnityEngine;

namespace Roads
{
    public class TurnRoad : MonoBehaviour, IRoad
    {
        private Ray _rayRight;
        private Ray _rayBack;
        private bool _isConnected;


        private void Start()
        {
            CheckRoadOnConnection();
        }

        public void Click()
        {
            if (!StartLevel.IsLevelStarted)
            {
                this.transform.Rotate(0, -90, 0);
                CheckRoadOnConnection();
            }
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            if (_isConnected)
                carTransform.Rotate(0, -90, 0);
            return startCarSpeed;
        }

        private void CheckRoadOnConnection()
        {
            RayInitializer();

            _isConnected = Physics.Raycast(_rayRight, out RaycastHit hit) & hit.collider != null &
                           Physics.Raycast(_rayBack, out hit) & hit.collider != null;
        }

        private void RayInitializer()
        {
            Vector3 position = transform.localPosition;
            _rayRight = new Ray(position, transform.TransformDirection(Vector3.right));
            _rayBack = new Ray(position, transform.TransformDirection(Vector3.back));
        }

        private void OnDrawGizmos()
        {
            CheckRoadOnConnection();

            Gizmos.color = _isConnected ? Color.green : Color.red;

            Gizmos.DrawRay(_rayRight.origin, _rayRight.direction);
            Gizmos.DrawRay(_rayBack.origin, _rayBack.direction);
        }
    }
}
