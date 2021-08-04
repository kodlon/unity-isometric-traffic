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
        MoveCar();
        RoadCheck();
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
        Vector3 forward = transform.TransformDirection(-Vector3.forward);

        transform.Translate((forward * Time.deltaTime) * currentCarSpeed);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.down);
        Gizmos.DrawRay(transform.position, direction);
    }
}
