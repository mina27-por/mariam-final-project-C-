using UnityEngine;

// This script controls player movement and jumping
public class PlayerController : MonoBehaviour
{
    // Movement speed of the player (left/right)
    public float moveSpeed = 5f;

    // Force applied when the player jumps
    public float jumpForce = 10f;

    // Reference to the Rigidbody2D component
    private Rigidbody2D rb;

    // Stores horizontal input (-1 to 1)
    private float moveInput;

    // Checks if the player is touching the ground
    private bool isGrounded;

    // Called once when the game starts
    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    // Called every frame (good for input handling)
    void Update()
    {
        // Get horizontal input (A/D or Left/Right arrows)
        moveInput = Input.GetAxis("Horizontal");

        // Check if Space key is pressed AND player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Apply upward velocity to make the player jump
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            // Set grounded to false so player can't jump again mid-air
            isGrounded = false;
        }
    }

    // Called at fixed intervals (best for physics updates)
    void FixedUpdate()
    {
        // Move the player left or right using velocity
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    // Called while the player is staying in collision with another object
    void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the object has the tag "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Player is on the ground
            isGrounded = true;
        }
    }
}
