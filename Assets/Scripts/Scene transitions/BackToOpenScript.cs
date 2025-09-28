using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOpenScript : MonoBehaviour
{
    public void ToStartScene()
    {
        SceneManager.LoadScene(3);
    }

    public void ToPlayScene()
    {
        SceneManager.LoadScene(1);
        AudioListener.pause = false;
    }

    public void ToEnding()
    {
        SceneManager.LoadScene(2);
    }

    public void ToTutorial()
    {
        SceneManager.LoadScene(5);
    }

    public void ToCredits()
    {
        SceneManager.LoadScene(6);
    }
}
