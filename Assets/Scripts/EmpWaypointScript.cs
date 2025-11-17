using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EmpWaypointScript : EmpScript
{


    public Transform[] nodes;
    private int destPoint = 0;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Alert.SetActive(false);
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
    }

    // Update is called once per frame
    void Update()
    {
        alertTransform.LookAt(Target.transform);
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            eHive.newJob();
            Debug.Log("triggered box");

        }
    }

    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (nodes.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = nodes[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % nodes.Length;
    }



}
