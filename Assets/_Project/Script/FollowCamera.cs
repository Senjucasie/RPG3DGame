using UnityEngine;

namespace RPG.Cam
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private Transform _targetToFollow;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = _targetToFollow.position;
        }
    }
}

