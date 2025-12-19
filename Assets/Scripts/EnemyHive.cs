using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class EnemyHive : MonoBehaviour
{
    public static EnemyHive instance;
    public PlayerUI playerUI;
    [SerializeField] List<EmpScript> statics;
    [SerializeField] List<EmpWaypointScript> waypoints;
    public GameObject player;
    int empsSpawned = 0;
    int currentJob = -1;


    // Start is called before the first frame update
    void Start()
    {
        
        statics.AddRange(waypoints);

        Debug.Log("emps count + " + statics.Count);


        Invoke(nameof(assignJob), 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void assignJob()
    {
        empsSpawned = statics.Count;
        currentJob = Random.Range(0, empsSpawned);
        statics[currentJob].Alert.SetActive(true);

    }


    public void newJob()
    {
        playerUI.money += 20;
        statics[currentJob].Alert.SetActive(false);
        assignJob();
    }


    
}
