using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private int carSpeed;

    private void Update()
    {


        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        GetComponent<Rigidbody>().AddForce(fwd * carSpeed);

        if (Physics.Raycast(transform.position, fwd, 2))
            print("There is something in front of the object!");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 2;
        Gizmos.DrawRay(transform.position, direction);
    }
}
