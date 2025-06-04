using UnityEngine;

public class MjolnirSpawner : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public int fishValue = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Target geraakt");
            Destroy(gameObject);

            Points.instance.punten(fishValue);
        }
    }
}
