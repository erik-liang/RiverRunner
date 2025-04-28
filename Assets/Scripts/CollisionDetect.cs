using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject player;
    void OnTriggerEnter(Collider other) {
        player.GetComponent<PlayerMovement>().enabled = false;
    }
}
