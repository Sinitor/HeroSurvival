using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
