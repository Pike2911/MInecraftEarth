using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private GameObject Block;
     
    private void Start()
    {
        
        int wild = 100;
        int length = 100;
        for (int x = 0; x < wild; x++)
        {
            
            for (int  z = 0; z < length; z++)
            {
                int y = Gethight(x, z);
                Instantiate(Block, new Vector3(x, y, z), transform.rotation);
            }
        }
        
    }
    int Gethight(int x, int z)
    {
        int y = 0;
        y = (int)(Mathf.PerlinNoise((float)x / 100.0f , (float)z / 100.0f) * 100);

        return y;
    }
}
