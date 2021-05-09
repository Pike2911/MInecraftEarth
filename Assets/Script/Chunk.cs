using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private GameObject Block;

    public int[,] map;

    private void Start()
    {


        int wide = 100;
        int length = 100;

        map = new int[wide, length];

        for (int x = 0; x < wide; x++)
        {
            for (int  z = 0; z < length; z++)
            {
                int y = Gethight(x, z);

                map[x, z] = y;

                Instantiate(Block, new Vector3(x, y, z), transform.rotation);
            }
        }


        //for (int i = 0; i < wide; i++)
        //{
        //    for (int j = 0; j < length; j++)
        //    {
        //        print(map[i, j]);
        //    }
        //}
        
    }

    int Gethight(int x, int z)
    {
        int y = 0;
        y = (int)(Mathf.PerlinNoise((float)x / 100.0f , (float)z / 100.0f) * 100);

        return y;
    }
}
