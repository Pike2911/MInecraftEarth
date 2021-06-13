using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PGME.Scene
{
    public class Block : MonoBehaviour
    {
        [SerializeField] private GameObject item = null;
        int _Hp = 3;

        public void TakeDamage()
        {
            _Hp = _Hp - 1;
        }

        void Die()
        {
            if (item != null)
            {
                Instantiate(item, transform.position, transform.rotation);
            }
            gameObject.SetActive(false);
        }

        public bool IsDeath()
        {
            return _Hp == 0;
        }

        private void Update()
        {
            if (_Hp == 0)
            {
                Die();
            }
        }
    }

}
