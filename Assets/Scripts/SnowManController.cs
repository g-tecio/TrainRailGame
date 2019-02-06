using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManController : MonoBehaviour {

    public float velocity = 1.2F;
    private Rigidbody2D rb;
    public sc csg = new sc();
    // Use this for initialization
    void Start()
    {
        csg = new sc();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * velocity;

    }

    // Update is called once per frame
    void Update()
    {
        if (sc.aber > 30)
        {
            rb.velocity = Vector2.down * 1.8F;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "kill")
        {
            
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
