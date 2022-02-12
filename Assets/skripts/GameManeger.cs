using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    bool gameIsEnded = false;

    public float restartDelay = 1f;

    public GameObject comleteLevelUI;

    public PlayerMoovment moovment;

    public void comliteLevl()
    {
        comleteLevelUI.SetActive(true);
        moovment.enabled = false;
    }

    public void Endgame()
    {
        if(gameIsEnded == false)
        {
            gameIsEnded = true;
            Debug.Log("Game OVER");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
