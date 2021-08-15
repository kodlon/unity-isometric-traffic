using UnityEngine;

namespace UI.HUD
{
    public class StartLevel : MonoBehaviour
    {
        public static bool IsLevelStarted { get; set; }


        public void OnPlayButtonPressed()
        {
            IsLevelStarted = true;
        }
        //TODO: Make event what call method in road to change collider size
        //Maybe create new interface
    }
}
