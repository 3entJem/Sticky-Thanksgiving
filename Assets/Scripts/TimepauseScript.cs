using UnityEngine;
using UnityEngine.UI;

public class TimepauseScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PauseTime()
    {
        Time.timeScale = 0f;
    }

    public void ContinueTime()
    {
        Time.timeScale = 1f;
    }
    
}
