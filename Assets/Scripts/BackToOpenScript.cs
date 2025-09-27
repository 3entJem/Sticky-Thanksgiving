using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOpenScript : MonoBehaviour
{
    public void ToStartScene()
    {
        SceneManager.LoadScene(0);
    }

}
