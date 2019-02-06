using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarbonGenerator : MonoBehaviour {
    public GameObject carbon;
 

    public float generatorTime = 2.75f;
    

    // Use this for initialization
    void Start()
    {
        Invoke("CreateEnemy", Random.Range(2, 20));
       

    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateEnemy()
    {
        Instantiate(carbon, transform.position, Quaternion.identity);
        Invoke("CreateEnemy", Random.Range(2, 20));


    }


    //metodo apra dejar de invocar una vez que muera el personaje, el metodo clean es apra limpiar enemigos que quedaron en pantallas
    public void CancelPrizeGenerator1(bool clean = false)
    {
        CancelInvoke("CreateEnemy");
        if (clean)
        {
            object[] allEnemies = GameObject.FindGameObjectsWithTag("Prize");
            foreach (GameObject enemy in allEnemies)
            {
                Destroy(enemy);
            }
        }
    }


}
