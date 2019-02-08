using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YetiController : MonoBehaviour {
    public float velocity = 4F;
    private Rigidbody2D rb;
    private Transform target;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("GetPrize").GetComponent<Transform>();
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, velocity * Time.deltaTime);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="DestroyerTop")
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
