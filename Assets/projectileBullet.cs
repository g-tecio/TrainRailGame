using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBullet : MonoBehaviour {
    public float speed;
    public float lifetime;
    public GameObject effect;
    public float distance;
   
	// Use this for initialization
	void Start () {
       
	}

    // Update is called once per frame
    void Update() {
        
        transform.Translate(Vector2.up * speed * Time.deltaTime);
	}

    /*void DestroyProjectile()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "kill")
        {
            print("SDdsd");
            Destroy(gameObject);
        }
    }
}
