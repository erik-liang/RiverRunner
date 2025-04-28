using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float horizontalSpeed = 10.0f;
    public float rightLimit = 7.0f;
    public float leftLimit = -7.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            if (this.gameObject.transform.position.x > leftLimit) {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            if (this.gameObject.transform.position.x < rightLimit) {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
            }
        }
    }
}
