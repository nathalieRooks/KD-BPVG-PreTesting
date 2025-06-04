using UnityEngine;

public class SpawnRocks : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = Vector2.left * speed;
    }
}
