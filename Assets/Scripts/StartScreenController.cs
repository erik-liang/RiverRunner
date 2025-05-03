using UnityEngine;
using UnityEngine.SceneManagement; // To manage scene transitions
using UnityEngine.UI; // For UI elements

public class StartScreen : MonoBehaviour
{
    public Button startButton;

    void Start()
    {
        // Ensure the startButton is assigned
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // Load the main game scene
        SceneManager.LoadScene("Game");
    }
}
