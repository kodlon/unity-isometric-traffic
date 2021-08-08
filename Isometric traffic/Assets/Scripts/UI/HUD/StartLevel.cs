using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public static bool isLevelStarted = false;

    

    public void OnPlayButtonPressed()
    {
        isLevelStarted = true;
    }
    //TODO: Make event what call method in road to change collider size
    //Maybe create new interface
}
