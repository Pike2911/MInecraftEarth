using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGME.Scene
{
    public class Chunk : MonoBehaviour
    {
        [SerializeField] private GameObject Block = null;
        [SerializeField] private GameObject Blockdirt = null;

        public int[,] map;
        public bool[,] mapVisible;


        int wide = 150;
        int length = 150;
        int hight = 2;
        int eyeSight = 5;

        GameObject player;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");

            map = new int[wide, length];
            mapVisible = new bool[wide, length];


            for (int x = 0; x < wide; x++)
            {
                for (int z = 0; z < length; z++)
                {
                    mapVisible[x, z] = false;
                }
            }    


            
        }
        private void Update()
        {

            Vector3 playerPosition = player.transform.position;

            int rightBound = (int)Mathf.Min(playerPosition.x + eyeSight,wide);
            int leftBound = (int)Mathf.Max(playerPosition.x - eyeSight,0);

            int bottomBound = (int)Mathf.Min(playerPosition.z + eyeSight, length);
            int topBound = (int)Mathf.Max(playerPosition.z - eyeSight,0);

            for (int x = leftBound; x < rightBound; x++)
            {
                for (int z = topBound; z < bottomBound; z++)
                {

                    for (int y = 0; y < hight; y++)
                    {
                        if (mapVisible[x, z] == false)
                        {
                            int offsety = Mathf.Max(GetHight(x, z), 28);

                            map[x, z] = offsety + y;

                            if (y < 1)
                            {
                                Instantiate(Blockdirt, new Vector3(x, y + offsety, z), transform.rotation);
                            }
                            else if (y == 1)
                            {
                                Instantiate(Block, new Vector3(x, y + offsety, z), transform.rotation);
                            }

                            mapVisible[x, z] = true;
                        }

                    }

                }
            }
        }
        int GetHight(int x, int z)
        {
            int y = 0;
            y = (int)(Mathf.PerlinNoise((float)x / 100.0f, (float)z / 100.0f) * 100);

            return y;
        }
    }
}

