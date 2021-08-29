using Roads;
using UI.HUD;
using UnityEngine;

namespace PlayerCar
{
    public class CarMove : MonoBehaviour
    {
        [SerializeField] private float startCarSpeed = 3;
        private float _currentCarSpeed;
        private string _roadName;
        private Vector3 _startPosition;


        private void Start()
        {
            RestartLevel.OnCount += RestartCar;
            
            _currentCarSpeed = startCarSpeed;
            _startPosition = transform.position;
        }

        private void Update()
        {
            if (StartLevel.IsLevelStarted)
            {
                MoveCar();
                RoadCheck();
            }
        }


        private void RoadCheck()
        {
            Ray ray = new Ray(transform.position, Vector3.down);

            if (Physics.Raycast(ray, out RaycastHit hit) & hit.collider != null)
            {
                IRoad road = hit.collider.GetComponent<IRoad>();
                if (road != null & (_roadName == null || hit.collider.name != _roadName))
                {
                    _currentCarSpeed = road.RoadBehaviour(_currentCarSpeed, startCarSpeed, transform);

                    _roadName = hit.collider.name;
                }
            }
            else //if no tiles under car
            {
                StartLevel.IsLevelStarted = false;
            }
        }

        private void MoveCar()
        {
            transform.Translate(Vector3.back * (Time.deltaTime * _currentCarSpeed));
        }

        private void RestartCar() //TODO: add check rotation, and after finish check 
        {
            Debug.Log("Restart");
            transform.position = _startPosition;
        }

        private void OnDrawGizmos()
        {
            Vector3 position = transform.position;

            Vector3 directionDown = transform.TransformDirection(Vector3.down);
            Vector3 directionBack = transform.TransformDirection(Vector3.back);

            Gizmos.color = _currentCarSpeed > 0 ? Color.green : Color.red;
            Gizmos.DrawRay(position, directionDown);
            Gizmos.DrawRay(position, directionBack);
        }
    }
}