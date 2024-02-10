using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 2.0f;
    public float wallJumpForce = 2.0f;
    private bool isJumping = false;
    private bool isWallJumping = false;
    private bool isTouchingWall = false;
    private bool isTouchingGround = false; // Added this line
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetButtonDown("Jump") && !isJumping && isTouchingGround) // Modified this line
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isJumping = true;
        }

        if (Input.GetButtonDown("Jump") && isJumping && !isWallJumping && isTouchingWall)
        {
            rb.AddForce(new Vector3(0, wallJumpForce, 0), ForceMode.Impulse);
            isWallJumping = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = true;
        }
        else if (collision.gameObject.tag == "Ground") // Added this line
        {
            isTouchingGround = true; // Added this line
            isJumping = false;
            isWallJumping = false;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isTouchingWall = false;
        }
        else if (collision.gameObject.tag == "Ground") // Added this line
        {
            isTouchingGround = false; // Added this line
        }
    }
}