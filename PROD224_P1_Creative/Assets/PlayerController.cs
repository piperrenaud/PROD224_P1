using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // prevents the Rigidbody from rotating
    }

    private void FixedUpdate()
    {
        // Get input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(moveX, 0f, moveZ).normalized;

        // Move using Rigidbody
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
