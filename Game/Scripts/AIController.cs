﻿using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour 
{
    public GameObject goal;
    private NavMeshAgent navMesh;

	void Start () 
    {
        navMesh = this.GetComponent<NavMeshAgent>();

        navMesh.destination = goal.transform.position;
	}
	
	void Update () 
    {
	    
	}
}
