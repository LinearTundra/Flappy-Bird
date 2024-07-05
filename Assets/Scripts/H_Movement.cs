using UnityEngine;

public class H_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (-speed, 0);
        Destroy(gameObject, 5f);
    }
}
