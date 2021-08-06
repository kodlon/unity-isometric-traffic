using UnityEngine;

public class TurnRoad : MonoBehaviour, IRoad
{
    Ray rayRight;
    Ray rayBack;
    bool isConnected = false;


    private void Update()
    {
        CheckRoadOnConnection();
    }

    public void Click()
    {
        this.transform.Rotate(0, -90, 0);
    }

    public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
    {
        carTransform.Rotate(0, -90, 0);
        return startCarSpeed;
    }

    private void CheckRoadOnConnection()
    {
        RaycastHit hitRight;
        RaycastHit hitBack;
        if (Physics.Raycast(rayRight, out hitRight) & hitRight.collider != null
            & Physics.Raycast(rayBack, out hitBack) & hitBack.collider != null)
        {
            isConnected = true;
        }
        else
        {
            isConnected = false;
        }
    }

    private void rayInitializer()
    {
        rayRight = new Ray(transform.position, transform.TransformDirection(Vector3.right));
        rayBack = new Ray(transform.position, transform.TransformDirection(Vector3.back));
    }

    private void OnDrawGizmos()
    {
        rayInitializer();
        if (isConnected)
            Gizmos.color = Color.green;
        else
            Gizmos.color = Color.red;
        Gizmos.DrawRay(rayRight.origin, rayRight.direction);
        Gizmos.DrawRay(rayBack.origin, rayBack.direction);
    }
}
