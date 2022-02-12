using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomlete : MonoBehaviour
{
    public void LoadNextLevl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
