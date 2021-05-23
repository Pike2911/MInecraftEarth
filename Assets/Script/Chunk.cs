using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private GameObject Block=null;
    [SerializeField] private GameObject Blockdirt=null;

    public int[,] map;

    private void Start()
    {


        int wide = 100;
        int length = 100;
        int hight = 4;

        map = new int[wide, length];

        for (int x = 0; x < wide; x++)
        {
            for (int  z = 0; z < length; z++)
            {
                for(int y = 0; y < hight; y++)
                {
                    int offsety = Mathf.Max(Gethight(x, z), 28);

                    map[x, z] = offsety + y;

                    if (y < 3)
                    {
                        Instantiate(Blockdirt, new Vector3(x, y + offsety, z), transform.rotation);
                    }
                    else if (y == 3)
                    {
                        Instantiate(Block, new Vector3(x, y + offsety, z), transform.rotation);
                    }
                }
                
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
