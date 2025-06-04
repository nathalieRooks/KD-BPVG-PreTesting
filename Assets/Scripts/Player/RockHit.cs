using UnityEngine;

public class RockHit : MonoBehaviour
{
    private Rigidbody2D rd;
    public int liveCount = 1;

    private void Start()
    {
        // Haalt rigidbody op
        rd = GetComponent<Rigidbody2D>();
    }

    // Bij aanraking met hook, wordt er een Haak gestart en gaat er een leven vanaf
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rock"))
        {
            Debug.Log("Vloer geraak");
            Destroy(gameObject);
            Lives.Instance.punten(liveCount);
        }
    }
}
