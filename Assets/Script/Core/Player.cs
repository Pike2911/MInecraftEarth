using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGME.Core
{
    public class Player : MonoBehaviour
    {

        public int wood = 0;
        public int dirt = 0;
        public int grass = 0;


        public void increaseBlock(string BlockType)
        {
            if(BlockType == "wood")
            {
                wood = wood + 10;

                Debug.Log(wood);
            }
            else if(BlockType == "dirt")
            {
                dirt = dirt + 20;

                Debug.Log(dirt);
            }
            else if(BlockType == "grass")
            {
                grass = grass + 30;

                Debug.Log(grass);
            }
        }

        public void decreaseBlock()
        {
            dirt -= 20;
        }

    }
}

   

