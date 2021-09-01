﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavCharacterController : CharacterController
{
    private NavMeshAgent _navMeshAgent;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    protected override void MoveTo(Vector3 target)
    {
        var objs = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (var obj in objs)
        {
            obj.GetComponentInChildren<NavMeshSurface>().BuildNavMesh();
        }

        _navMeshAgent.destination = target;
    }

}
