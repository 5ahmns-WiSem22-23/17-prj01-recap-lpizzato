using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 150f;
    [SerializeField] float rotation = 5f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, horizontalInput * rotation);

        rb.AddForce(-transform.right * speed * verticalInput);
    }
}