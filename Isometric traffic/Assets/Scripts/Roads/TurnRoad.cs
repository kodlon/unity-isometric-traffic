using UnityEngine;

public class TurnRoad : MonoBehaviour, IRoad
{
    public void Click()
    {
        this.transform.Rotate(0, -90, 0);
    }

    public float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform)
    {
        carTransform.Rotate(0, -45, 0);
        return startCarSpeed;
    }
}
