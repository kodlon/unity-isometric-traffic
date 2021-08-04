using UnityEngine;

public interface IRoad
{
    void Click();

    float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform);
}

