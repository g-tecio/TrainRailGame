using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorUpController : MonoBehaviour {
    
    public GameObject YetiPrefab;
   
    public float generatorTime = 2.75f;
    // Use this for initialization
    void Start()
    {
       ;
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
}
