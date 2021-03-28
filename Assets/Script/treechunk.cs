using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treechunk : MonoBehaviour
{
    [SerializeField] private GameObject Treeload;
    private int _bigtree;

    private void Start()
    {
        _bigtree = 0;
        for (int _bigtree = 0; _bigtree < 10; _bigtree++)
        {
            Instantiate(Treeload,new Vector3(Random.Range(0,100), 0, Random.Range(0,100)),transform.rotation); 
        }
    }
}
