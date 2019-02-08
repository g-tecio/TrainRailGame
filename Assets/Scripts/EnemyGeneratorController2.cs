using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorController2 : MonoBehaviour {
    public GameObject woodPrefab;
    public GameObject SnowPrefab;

    public float generatorTime = 2.75f;
    public float generatorTimeSnow = 4.75f;

    // Use this for initialization
    void Start()
    {
        Invoke("CreateEnemy", Random.Range(2, 15));
        Invoke("CreateEnemySnow", Random.Range(3, 13));

    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateEnemy()
    {
        Instantiate(woodPrefab, transform.position, Quaternion.identity);
        Invoke("CreateEnemy", Random.Range(2,15));

    }

    void CreateEnemySnow()
    {
        Instantiate(SnowPrefab, transform.position, Quaternion.identity);
        Invoke("CreateEnemySnow", Random.Range(3, 13));
    }

    //metodo apra dejar de invocar una vez que muera el personaje, el metodo clean es apra limpiar enemigos que quedaron en pantallas
    public void CancelGenerator2(bool clean = false)
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
