using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorController3 : MonoBehaviour {

    public GameObject woodPrefab;
    public GameObject SnowPrefab;

    public float generatorTime = 10000f;
    public float generatorTimeSnow = 6.75f;

    // Use this for initialization
    void Start()
    {
        Invoke("CreateEnemy", Random.Range(3,9));
        Invoke("CreateEnemySnow", Random.Range(2, 10));

    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateEnemy()
    {
        Instantiate(woodPrefab, transform.position, Quaternion.identity);
        Invoke("CreateEnemy", Random.Range(2, 7));
    }

    void CreateEnemySnow()
    {
        Instantiate(SnowPrefab, transform.position, Quaternion.identity);
        Invoke("CreateEnemySnow", Random.Range(2, 10));
    }
    //metodo apra dejar de invocar una vez que muera el personaje, el metodo clean es apra limpiar enemigos que quedaron en pantallas
    public void CancelGenerator3(bool clean = false)
    {
        CancelInvoke("CreateEnemy");
        CancelInvoke("CreateEnemySnow");
        if (clean)
        {
            object[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in allEnemies)
            {
                Destroy(enemy);
            }
        }
    }
}
