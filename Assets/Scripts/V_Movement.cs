using UnityEngine;

public class V_Movement : MonoBehaviour
{
    [SerializeField] private float max_speed;
    [SerializeField] private float RotationSpeed;
    private Vector2 up;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        up = new Vector2 (0, 10);
    }

    void Update() {

        if ( rb.velocity.magnitude > max_speed ) {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, max_speed);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.up * max_speed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * RotationSpeed);
    }

}
