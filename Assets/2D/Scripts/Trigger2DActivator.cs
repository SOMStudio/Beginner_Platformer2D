using UnityEngine;
using UnityEngine.Events;

namespace _2D.Scripts
{
    public class Trigger2DActivator : MonoBehaviour
    {
        public UnityEvent<Collider2D> onTriggerEnter2D;
        public UnityEvent<Collider2D> onTriggerStay2D;
        public UnityEvent<Collider2D> onTriggerExit2D;
        public bool checkTrigger = true;
        public string nameTag = "Player";

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!checkTrigger || (checkTrigger && other.gameObject.CompareTag(nameTag)))
            {
                onTriggerEnter2D?.Invoke(other);
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (!checkTrigger || (checkTrigger && other.gameObject.CompareTag(nameTag)))
            {
                onTriggerStay2D?.Invoke(other);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!checkTrigger || (checkTrigger && other.gameObject.CompareTag(nameTag)))
            {
                onTriggerExit2D?.Invoke(other);
            }
        }
    }
}
