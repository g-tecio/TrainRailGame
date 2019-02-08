using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
    public GameObject bullet;
    public GameObject bullet2;
    public Transform shotPoint;
    public Transform shotPoint2;
    private float  timeBtwShots;
    public float startTimeBtwShots;

    // Use this for initialization
    void Start () {
		
	}

    public void shootBehind()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(bullet2, shotPoint2.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }

        else
        {
            timeBtwShots -= Time.deltaTime;
        }



    }

    public void shootFront()
    {
        if (timeBtwShots <= 0)
        {

            Instantiate(bullet, shotPoint.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;



        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }





    }
    // Update is called once per frame
    void Update () {
        //Disparar en direccion y calcular cada cuando se puede ahcer
        if (timeBtwShots <= 0)
        {
            /*if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, shotPoint.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
            }*/
           if (Input.GetKeyDown(KeyCode.Space))
            {

                Instantiate(bullet2, shotPoint2.position, Quaternion.identity);
                timeBtwShots = startTimeBtwShots;
            }

        }
        else
        {
            timeBtwShots -=Time.deltaTime;
        }
      
	}
}
