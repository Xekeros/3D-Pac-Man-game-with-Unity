using UnityEngine;

public class TeleportWithFixedCoordinates : MonoBehaviour
{
    public GameObject player; // The player GameObject with Rigidbody

    // Fixed coordinates for teleportation
    private Vector3 teleportCoordinates = new Vector3(-0.12f, 0.04f, 7.5f);

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.gameObject == player)
        {
            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        if (player == null)
        {
            Debug.LogError("Player is not assigned!");
            return;
        }

        // Get the Rigidbody component
        Rigidbody rb = player.GetComponent<Rigidbody>();

        // Temporarily disable physics
        if (rb != null && !rb.isKinematic)
        {
            rb.isKinematic = true; // Disable physics
        }

        // Teleport the player to the fixed coordinates
        player.transform.position = teleportCoordinates;

        // Reset velocity only if the Rigidbody is not kinematic
        if (rb != null && !rb.isKinematic)
        {
            rb.velocity = Vector3.zero;

            // Do not set angular velocity on kinematic bodies
            rb.angularVelocity = Vector3.zero;

            // Re-enable physics
            rb.isKinematic = false;
        }

        Debug.Log($"Player teleported to {teleportCoordinates}");
    }
}
