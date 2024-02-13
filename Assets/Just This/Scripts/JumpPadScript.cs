using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    public float jumpForce = 10f; // The force with which the player will be launched

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the player's Rigidbody component
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                // Apply an upward force to the player
                playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            }
        }
    }
}