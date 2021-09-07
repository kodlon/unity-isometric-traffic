using DG.Tweening;
using UI.HUD;
using UnityEngine;

namespace Roads
{
    public class TurnRoad : MonoBehaviour, IRoad
    {
        private Ray _rayRight;
        private Ray _rayBack;
        private Ray _rayLeftTurn;
        private Ray _rayRightTurn;
        private bool _isConnected;


        private void Start()
        {
            CheckRoadOnConnection();
        }

        private void Update()
        {
            CheckRoadOnConnection(); //TODO: make without update
        }

        public void Click()
        {
            if (!StartLevel.IsLevelStarted && transform.rotation.eulerAngles.y % 90 == 0)
            {
                transform.DORotate(new Vector3(0, transform.rotation.eulerAngles.y - 90, 0),
                    0.2f);
                CheckRoadOnConnection();
            }
        }

        public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
        {
            //TODO: normal speed of car rotation, basic on startCarSpeed
            if (_isConnected)
            {
                if (Physics.Raycast(_rayRightTurn, out RaycastHit hit) && hit.collider != null && hit.distance < 1)
                {
                    carTransform.DORotate(new Vector3(0, carTransform.rotation.eulerAngles.y - 90, 0), 1f);
                }
                else if (Physics.Raycast(_rayLeftTurn, out RaycastHit hitL) && hitL.collider != null && hitL.distance < 1)
                {
                    carTransform.DORotate(new Vector3(0, carTransform.rotation.eulerAngles.y + 90, 0), 1f);
                }
                else
                {
                    return 0; // if null turn
                }
            }

            return 1.2f;
        }

        private void CheckRoadOnConnection()
        {
            RayInitializer();

            _isConnected = Physics.Raycast(_rayRight, out RaycastHit hit) && hit.collider != null &&
                           hit.distance < 1f &&
                           Physics.Raycast(_rayBack, out hit) && hit.collider != null && hit.distance < 1f;
        }

        private void RayInitializer()
        {
            Vector3 position = transform.localPosition;
            _rayRight = new Ray(position, transform.TransformDirection(Vector3.right));
            _rayBack = new Ray(position, transform.TransformDirection(Vector3.back));
            _rayLeftTurn = new Ray(position + -transform.forward / 2 - Vector3.up / 4f, transform.TransformDirection(Vector3.up));
            _rayRightTurn = new Ray(position + transform.right / 2 - Vector3.up / 4f, transform.TransformDirection(Vector3.up));
        }

        private void OnDrawGizmos()
        {
            CheckRoadOnConnection();

            Gizmos.color = _isConnected ? Color.green : Color.red;

            Gizmos.DrawRay(_rayRight.origin, _rayRight.direction);
            Gizmos.DrawRay(_rayBack.origin, _rayBack.direction);
            Gizmos.DrawRay(_rayLeftTurn.origin, _rayLeftTurn.direction);
            Gizmos.DrawRay(_rayRightTurn.origin, _rayRightTurn.direction);
        }
    }
}