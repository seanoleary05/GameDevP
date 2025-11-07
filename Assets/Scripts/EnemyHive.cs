using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class EnemyHive : MonoBehaviour
{
    public static EnemyHive instance;
    public PlayerUI playerUI;
    [SerializeField] EmpScript[] emps;
    public GameObject player;
    int empsSpawned = 0;
    int currentJob = -1;


    // Start is called before the first frame update
    void Start()
    {

        Invoke(nameof(assignJob), 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void assignJob()
    {
        empsSpawned = emps.Length;
        currentJob = Random.Range(0, empsSpawned);
        Debug.Log(empsSpawned + " + " + currentJob);
        emps[currentJob].Alert.SetActive(true);

    }


    public void newJob()
    {
        playerUI.money += 20;
        emps[currentJob].Alert.SetActive(false);
        assignJob();
    }


    
}
