using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject restartPanel;  // Drag the restart panel here in the Inspector

    void OnTriggerEnter(Collider other)
    {
        // Stop the player
        player.GetComponent<PlayerMovement>().enabled = false;

        // Show the Game Over screen
        restartPanel.SetActive(true);
    }
}
