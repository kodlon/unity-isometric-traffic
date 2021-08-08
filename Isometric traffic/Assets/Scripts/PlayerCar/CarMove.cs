using Roads;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float startCarSpeed = 3;
    private float currentCarSpeed;
    private string roadName;


    private void Start()
    {
        currentCarSpeed = startCarSpeed;
    }

    private void Update()
    {
        if (StartLevel.isLevelStarted)
        {
            MoveCar();
            RoadCheck();
        }
    }

    private void RoadCheck()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) & hit.collider != null)
        {
            IRoad road = hit.collider.GetComponent<IRoad>();
            if (road != null & (roadName == null || hit.collider.name != roadName))
            {
                currentCarSpeed = road.RoadBehaviour(currentCarSpeed, startCarSpeed, transform);

                roadName = hit.collider.name;
            }

        }
    }

    private void MoveCar()
    {
        transform.Translate((Vector3.back * Time.deltaTime) * currentCarSpeed);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = currentCarSpeed > 0 ? Color.green : Color.red;

        Vector3 directionDown = transform.TransformDirection(Vector3.down);
        Gizmos.DrawRay(transform.position, directionDown);

        Vector3 directionBack = transform.TransformDirection(Vector3.back);
        Gizmos.DrawRay(transform.position, directionBack);
    }
}
