using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    
        public bool OneShot;
        private bool _isAlreadyEntered;
        private bool _isAlreadyExited;

        public string CollisionTag;

        public UnityEvent OnEnter;
        public UnityEvent OnExit;

        private void OnTriggerEnter(Collider collision)
        {
            if (_isAlreadyEntered)
                return;

            if (!string.IsNullOrEmpty(CollisionTag) && !collision.CompareTag(CollisionTag))
                return;

            OnEnter?.Invoke();

            if (OneShot)
                _isAlreadyEntered = true;
        }

        private void OnTriggerExit(Collider collision)
        {
            if (_isAlreadyExited)
                return;

            if (!string.IsNullOrEmpty(CollisionTag) && !collision.CompareTag(CollisionTag))
                return;

            OnExit?.Invoke();

            if (OneShot)
                _isAlreadyExited = true;
        }
}
