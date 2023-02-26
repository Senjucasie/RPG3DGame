using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private Animator _characterAnimator;
    private NavMeshAgent _navmeshAgent;

    private Vector3 _velocity,_localVelocity;

    private void Start()
    {
        _navmeshAgent = GetComponent<NavMeshAgent>();
        _characterAnimator = GetComponent<Animator>();
    }

    private void Update()
    { 
       UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        _velocity = _navmeshAgent.velocity;
        _localVelocity = transform.InverseTransformDirection(_velocity);
        _characterAnimator.SetFloat("ForwardSpeed", _localVelocity.z);
    }

  

    public void MoveToPoint(Vector3 terrainpos)
    {
        _navmeshAgent.destination = terrainpos;
    }
}
