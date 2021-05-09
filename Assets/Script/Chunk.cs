using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private GameObject Block;

    private void Start()
    {

        int width = 100;
        int length = 100;

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < length; z++)
            {

                int y = GetHight(x, z);

                Instantiate(Block,
                             new Vector3(x, y, z),
                             transform.rotation);

            }
        }
        
    }


    int GetHight(int x, int z)
    {
        int y = 0;
        float x_f = (float)x / 100.0f;
        float z_f = (float)z / 100.0f;
        float noise = Mathf.PerlinNoise(x_f, z_f);
        y = (int)(noise * 100);

        return y ;
    }
}
