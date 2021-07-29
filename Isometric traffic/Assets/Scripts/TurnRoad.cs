using UnityEngine;

public class TurnRoad : MonoBehaviour
{
    public void RotateTile()
    {
        this.transform.Rotate(0, 0, -90);
    }
}
