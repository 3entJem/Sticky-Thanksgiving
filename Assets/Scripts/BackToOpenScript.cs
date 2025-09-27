using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOpenScript : MonoBehaviour
{
    public void ToStartScene()
    {
        SceneManager.LoadScene(4);
    }

    public void ToPlayScene()
    {
        SceneManager.LoadScene(5);
    }

    public void ToWin()
    {
        SceneManager.LoadScene(2);
    }

    public void ToLose()
    {
        SceneManager.LoadScene(3);
    }
}
