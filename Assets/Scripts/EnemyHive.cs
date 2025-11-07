using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHive : MonoBehaviour
{
    [SerializeField] EmpScript[] emps;
    public GameObject player;
    int empsSpawned = 0;
    int currentJob = -1;


    // Start is called before the first frame update
    void Start()
    {
        empsSpawned = emps.Length;
        currentJob = Random.Range(0, empsSpawned);
        Debug.Log(empsSpawned + " + " + currentJob);
        assignJob();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void assignJob()
    {
        emps[currentJob].Alert.SetActive(true);
    }


    
}
