using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void OnFullRestartButtonPressed()
    {
        StartLevel.isLevelStarted = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }    
    
    public void OnRestartButtonPressed()
    {
        StartLevel.isLevelStarted = false;
    }
}
