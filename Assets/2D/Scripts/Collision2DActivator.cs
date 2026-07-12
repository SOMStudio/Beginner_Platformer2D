using UnityEngine;
using UnityEngine.Events;

namespace _2D.Scripts
{
    public class Collision2DActivator : MonoBehaviour
    {
        public UnityEvent<Collision2D> onCollisionEnter2D;
        public UnityEvent<Collision2D> onCollisionStay2D;
        public UnityEvent<Collision2D> onCollisionExit2D;
        public bool checkTrigger = true;
        public string nameTag = "Player";

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!checkTrigger || (checkTrigger && other.gameObject.CompareTag(nameTag)))
            {
                onCollisionEnter2D?.Invoke(other);
            }
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            if (!checkTrigger || (checkTrigger && other.gameObject.CompareTag(nameTag)))
            {
                onCollisionStay2D?.Invoke(other);
            }
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (!checkTrigger || (checkTrigger && other.gameObject.CompareTag(nameTag)))
            {
                onCollisionExit2D?.Invoke(other);
            }
        }
    }
}
