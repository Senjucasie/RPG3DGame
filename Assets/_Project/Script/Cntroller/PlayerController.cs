using RPG.Core;
using UnityEngine;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        [SerializeField] private Camera _camera;

        void Start()
        {

        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                CreateRayCast();
            }
        }

        private void CreateRayCast()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool hashit = Physics.Raycast(ray, out hit);

            if (hashit)
                _mover.MoveToPoint(hit.point);
        }
    }

}
