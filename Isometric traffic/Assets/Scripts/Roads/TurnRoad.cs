using DG.Tweening;
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
            if (!StartLevel.IsLevelStarted && transform.rotation.eulerAngles.y % 90 == 0)
            {
                transform.DORotate(new Vector3(0, transform.rotation.eulerAngles.y - 90, 0), 1);

                CheckRoadOnConnection();
            }
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            //TODO: normal speed of car rotation, basic on startCarSpeed
            //TODO: rotation car with road position
            if (_isConnected) 
                carTransform.DORotate(new Vector3(0, carTransform.rotation.eulerAngles.y - 90, 0), 1f); 
            return 1.2f;
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