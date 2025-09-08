using UnityEngine;
using UnityEngine.Events;

namespace Supertactic.ReusableTriggers
{
    public class TriggerZone2D : MonoBehaviour
    {
        public bool OneShot;
        private bool _isAlreadyEntered;
        private bool _isAlreadyExited;

        public string CollisionTag;

        [Header("Events")]
        public UnityEvent OnEnter;
        public UnityEvent OnExit;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (_isAlreadyEntered)
                return;

            if (!string.IsNullOrEmpty(CollisionTag) && !collision.CompareTag(CollisionTag))
                return;

            OnEnter?.Invoke();

            if (OneShot)
                _isAlreadyEntered = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
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
}