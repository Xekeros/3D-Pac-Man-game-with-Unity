using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Movement speed
    public TextMeshProUGUI countText; // Count PickUp Text 
    private Vector3 moveDirection = Vector3.zero; // Current direction of movement
    private int count;
    public GameObject winTextObject;

    void Start()
    {
        count = 0;
        // Set an initial movement direction
        moveDirection = Vector3.forward; // Start moving forward
        SetCountText();
        winTextObject.SetActive(false);
    }

    void Update()
    {
        // Check for input to change direction
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveDirection = Vector3.forward; // Change direction to up
            transform.rotation = Quaternion.Euler(0, 0, 0); // Face forward
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDirection = Vector3.back; // Change direction to down
            transform.rotation = Quaternion.Euler(0, 180, 0); // Face backward
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDirection = Vector3.left; // Change direction to left
            transform.rotation = Quaternion.Euler(0, 270, 0); // Face left
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDirection = Vector3.right; // Change direction to right
            transform.rotation = Quaternion.Euler(0, 90, 0); // Face right
        }
    }

    void FixedUpdate()
    {
        // Move Pac-Man at constant speed in the current direction
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 173)
        {
            winTextObject.SetActive(true);
        }
    }
}
