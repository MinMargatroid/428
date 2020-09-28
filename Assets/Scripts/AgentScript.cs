using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    public Transform wayfindingTarget;
    private NavMeshAgent navMeshAgent;
    private bool touchPig;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(transform.position, wayfindingTarget.position) > 1){
            //navMeshAgent.SetDestination(navMeshAgent.destination);
        }

        if (((Mathf.Abs(navMeshAgent.destination.x - navMeshAgent.nextPosition.x) <= 2.05f) && (Mathf.Abs(navMeshAgent.destination.z - navMeshAgent.nextPosition.z) <= 2.05f)) 
        || ((Mathf.Abs(navMeshAgent.destination.x - navMeshAgent.nextPosition.x) <= 8.05f) && (Mathf.Abs(navMeshAgent.destination.z - navMeshAgent.nextPosition.z) <= 8.05f) && (touchPig == true))
        )

        {
            navMeshAgent.ResetPath();
        }
    }

    void OnCollisionStay(Collision other)
    {
        if(other.gameObject.CompareTag("Pig"))
        {
            touchPig = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Pig"))
        {
            touchPig = false;
        }
    }
}
