using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGME.Core
{
    public class Player : MonoBehaviour
    {
        private int myscore = 0;

        public void increaseBlock()
        {
            myscore = myscore + 10;

            Debug.Log(myscore);
        }
    }
}

   

