using UnityEngine;

public class MinimapIcon : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        // Match the player's position but keep the icon at the same height
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        // Optional: Match the player's rotation for an arrow-style icon
        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
