using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    int _Hp = 3;
  
    public void TakeDamage ()
    {
        _Hp = _Hp - 1;
    }

    void die()
    {
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
