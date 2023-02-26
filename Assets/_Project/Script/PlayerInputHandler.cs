
using RPG.Movement;
using UnityEngine;

namespace RPG.PlayerInput
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private Mover _mover;

        // Update is called once per frame
        void Update()
        {
        if (Input.GetMouseButton(0))
            CreateRayCast();
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
