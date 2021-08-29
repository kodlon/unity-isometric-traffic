using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.HUD
{
    public class RestartLevel : MonoBehaviour
    {
        public delegate void MethodContainer();
        public static event MethodContainer OnCount;
    
        public void OnFullRestartButtonPressed()
        {
            StartLevel.IsLevelStarted = false;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }    
    
        public void OnRestartButtonPressed()
        {
            StartLevel.IsLevelStarted = false;
            if (OnCount != null) OnCount();
        }
    }
}
