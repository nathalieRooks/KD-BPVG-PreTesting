using UnityEngine;

public class Hook : MonoBehaviour
{
    public float fallspeed = 1f;
    private Rigidbody2D rb;

    public int fishValue = 1;
    public Transform spawnpoint;


    private void Start()
    {
        // Haalt Rigid
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Bij pijltje naar beneden start startFalling
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            startFalling();
        }
    }

    // Laat de dobber vallen
    void startFalling()
    {
        rb.gravityScale = 1;
        rb.linearVelocity = new Vector2(0, -fallspeed);
        transform.parent = null;
    }

    // Bij aanraking target punt er bij en verwijderd de target
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("target"))
        {
            Debug.Log("Target geraakt");
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0;

            Destroy(other.gameObject);

            Respawn();

            Points.instance.punten(fishValue);
        }
    }

    // Spawned nieuwe haak
    public void Respawn()
    {
        this.transform.position = spawnpoint.position;

        //Haak aan spawnpoint vast maken
        this.transform.SetParent(spawnpoint);

        // Reset van fyscia
        rb.gravityScale = 0;
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0;
    }
}
