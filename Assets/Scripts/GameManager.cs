using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        MasterInfo.coinCount = 0;  // 🧹 Reset coin count
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
