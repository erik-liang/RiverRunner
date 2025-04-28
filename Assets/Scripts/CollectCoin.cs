using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        MasterInfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
