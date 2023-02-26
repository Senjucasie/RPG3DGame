using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _target;
    private NavMeshAgent _navmeshAgent;

    private void Start()
    {
        _navmeshAgent = GetComponent<NavMeshAgent>();
       
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveOnClick();
        }
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
