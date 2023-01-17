using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float currentSpeed = 100f;
    [SerializeField] float normalSpeed = 100f;
    [SerializeField] float slowSpeed = 50f;
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

        rb.AddForce(-transform.right * currentSpeed * verticalInput);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            currentSpeed = slowSpeed;
            StartCoroutine(SpeedToNormal());
        }
    }

    IEnumerator SpeedToNormal()
    {
        yield return new WaitForSeconds(5);
        currentSpeed = normalSpeed;
    }
}