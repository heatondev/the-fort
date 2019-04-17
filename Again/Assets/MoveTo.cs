using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {

    public Transform goal;
    public float[] locations;

    void Start()
    {
       
    }

	
	// Update is called once per frame
	void Update () {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
	}
}
