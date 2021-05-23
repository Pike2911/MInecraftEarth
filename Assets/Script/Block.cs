using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject item=null;
    int _Hp = 3;
  
    public void TakeDamage ()
    {
        _Hp = _Hp - 1;
    }

    void die()
    {
        Instantiate(item, transform.position,transform.rotation);
         
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_Hp == 0)
        {
            die();
        }
    }
}
