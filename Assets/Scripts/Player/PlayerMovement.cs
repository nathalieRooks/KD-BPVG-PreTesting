using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 2f;

    Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }


}
