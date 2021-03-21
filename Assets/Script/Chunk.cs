using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private GameObject Block;
    private int _floor;
    private int _floor1;

    private void Start()
    {
        _floor = 0;
        _floor1 = 0;
        for (int _floor = 0; _floor < 100; _floor++)
        {
            
            for (int _floor1 = 0; _floor1 < 100; _floor1++)
            {
                Instantiate(Block, new Vector3(_floor, 0, _floor1), transform.rotation);
            }
        }
        
    }
}
