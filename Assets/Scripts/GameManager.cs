using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        MasterInfo.coinCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        MasterInfo.coinCount = 0; // Optional reset
        SceneManager.LoadScene("StartScreen"); // Replace with your actual start menu scene name
    }
}
