using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeChunk : MonoBehaviour
{
    [SerializeField] private GameObject Treeload=null;

    private List<GameObject> trees;

    private void Start()
    {
        trees = new List<GameObject>();

        int x1 = Random.Range(0, 100);
        int z1 = Random.Range(0, 100);
        int y1 = GetComponent<Chunk>().map[x1, z1];

        trees.Add(Instantiate(Treeload, new Vector3(x1, y1, z1),transform.rotation));

        int Count = 0;

        while ( trees.Count < 100 && Count < 100)
        {
            Count++;

            Vector3 loc = new Vector3(Random.Range(0, 100), 1, Random.Range(0, 100));

            bool canplant = true;
            for (int i = 0; i < trees.Count; i++)
            {
                float b = Mathf.Abs(trees[i].transform.position.x - loc.x);
                float a = Mathf.Abs(trees[i].transform.position.z - loc.z);
                float c = Mathf.Sqrt(a * a + b * b);

                if (c < 10)
                {
                    canplant = false;
                    break;
                }
            }
            if (canplant)
            {
                loc.y = GetComponent<Chunk>().map[ (int)loc.x, (int)loc.z ];

                trees.Add(Instantiate(Treeload, loc, transform.rotation));

            }
        }
    }
}
