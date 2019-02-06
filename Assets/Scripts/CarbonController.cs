using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarbonController : MonoBehaviour {
    public float velocity = 0.5F;
    private Rigidbody2D rb;
    public int cont;
    public int cont2;
    public sc csg=new sc();
    public Text CountText;
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

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "GetPrize")
        {
            cont2 = 2;
            sc.aber += 2;
            
           

            Destroy(gameObject);
            

        }

    }

  

   
}
