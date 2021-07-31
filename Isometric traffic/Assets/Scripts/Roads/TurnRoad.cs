using UnityEngine;

public class TurnRoad : MonoBehaviour, IRoadClicked
{
    public void Click()
    {
        this.transform.Rotate(0, -90, 0);
    }

}
