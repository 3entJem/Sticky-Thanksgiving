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
    }

    public void ToEnding()
    {
        SceneManager.LoadScene(2);
    }
}
