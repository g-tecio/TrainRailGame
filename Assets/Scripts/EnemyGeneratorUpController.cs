using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorUpController : MonoBehaviour {
    
    public GameObject YetiPrefab;
   
    public float generatorTime = 2.75f;
    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
       
=======
       ;
>>>>>>> origin/master
        InvokeRepeating("CreateEnemyYeti", 3f, generatorTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyYeti()
    {
        Instantiate(YetiPrefab, transform.position, Quaternion.identity);
    }
<<<<<<< HEAD
    //metodo apra dejar de invocar una vez que muera el personaje, el metodo clean es apra limpiar enemigos que quedaron en pantallas
    public void CancelGeneratorYeti(bool clean = false)
    {
        CancelInvoke("CreateEnemyYeti");
        
        if (clean)
        {
            object[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in allEnemies)
            {
                Destroy(enemy);
            }
        }
    }
=======
>>>>>>> origin/master
}
