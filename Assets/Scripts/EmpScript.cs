using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EmpScript : MonoBehaviour
{
    public static EmpScript instance;
    public EnemyHive eHive;
    public GameObject Alert;
    public bool isActive = false;
    public Transform Target;
    public Transform alertTransform;
    // Start is called before the first frame update
    void Start()
    {
        Alert.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        alertTransform.LookAt(Target.transform);   
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            eHive.newJob();
            Debug.Log("triggered box");

        }
    }
}
