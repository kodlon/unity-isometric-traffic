using UnityEngine;

namespace Roads
{
    public interface IRoad
    {
        /// <summary>
        /// Called when mouse clicked on object.
        /// </summary>
        void Click();

        /// <summary>
        /// The impact of the road on the player's car.
        /// </summary>
        /// <param name="currentCarSpeed">Current speed of player car.</param>
        /// <param name="startCarSpeed">Start speed of player car.</param>
        /// <param name="carTransform">Player car transform.</param>
        /// <returns></returns>
        float RoadBehaviour(float currentCarSpeed, float startCarSpeed, Transform carTransform);
    }
}

