using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private Camera _camera;
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
        if(Input.GetMouseButtonDown(0))
        {
            MoveOnClick();
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        _velocity = _navmeshAgent.velocity;
        _localVelocity = transform.InverseTransformDirection(_velocity);
        _characterAnimator.SetFloat("ForwardSpeed", _localVelocity.z);
    }

    private void MoveOnClick()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hashit = Physics.Raycast(ray, out hit);

        if (hashit)
            _navmeshAgent.destination = hit.point;


    }
}
