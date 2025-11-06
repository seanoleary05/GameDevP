using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHive : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    int enemiesSpawned = 0;
    int currentJob = -1;


    // Start is called before the first frame update
    void Start()
    {
        enemiesSpawned = enemies.Length;
        currentJob = Random.Range(0, enemiesSpawned);
        Debug.Log(enemiesSpawned + " + " + currentJob);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void assignJob()
    {
       // enemies[currentJob].Alert.setActive(true);
    }
}
