using UnityEngine;

public class ItemPickupScript : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed at which the item will spin
    public PlayerCounterScript playerCounterScript; // Reference to the PlayerCounterScript

    void Update()
    {
        // Make the item spin
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Increase the counter
            playerCounterScript.IncreaseCounter();

            // Destroy the item
            Destroy(gameObject);
        }
    }
}