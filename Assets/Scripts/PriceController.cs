using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceController : MonoBehaviour {
    public float velocity= 0.76F;
    private Rigidbody2D rb;
    public sc csg = new sc();
    // Use this for initialization
    void Start () {
        csg = new sc();
        rb = GetComponent<Rigidbody2D>();
        if (sc.aber <= 100)
        {
            rb.velocity = Vector2.down * velocity;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        if (sc.aber > 25)
        {
            rb.velocity = Vector2.down * 1.5F;
        }
        if (sc.aber > 50)
        {
            rb.velocity = Vector2.down * 2F;

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
         if(other.gameObject.tag == "kill")
        {
            print("Aqui");
            
          
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        
    }
}
