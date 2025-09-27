using UnityEngine;
using UnityEngine.UI;

public class TimepauseScript : MonoBehaviour
{

    public AudioSource battlefield;
    public void PauseTime()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
    }

    public void ContinueTime()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }
    
}
