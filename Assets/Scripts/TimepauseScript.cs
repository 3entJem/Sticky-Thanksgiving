using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimepauseScript : MonoBehaviour
{

    public AudioSource battlefield;
    public GameObject backsquare;
    public GameObject image;
    public Button pause;
    public Button backtogame;
    public Button toopener;
    public Button quit;
    
    public void PauseTime()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
        //backsquare.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
        pause.gameObject.SetActive(false);
        backtogame.gameObject.SetActive(true);
        toopener.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
    }

    public void ContinueTime()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        backsquare.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
        pause.gameObject.SetActive(true);
        backtogame.gameObject.SetActive(false);
        toopener.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }
    
}
