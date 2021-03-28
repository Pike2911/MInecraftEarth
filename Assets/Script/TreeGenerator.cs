using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    [SerializeField] int _numTrees = 10;
    [SerializeField] GameObject _treePrefab;

    
    void Start()
    {
        for(int i=0; i<_numTrees; i++)
        {
            Debug.Log(Random.Range(0,20));
            //Instantiate(_treePrefab, new Vector3(Random.Range(0,20), 1, Random.Range(0, 20)), transform.rotation);
        }
    }

    
    void Update()
    {
        
    }
}
