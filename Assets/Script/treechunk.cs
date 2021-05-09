using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treechunk : MonoBehaviour
{
    [SerializeField] private GameObject Treeload;
    private int _bigtree;

    private List<GameObject> trees;

    private void Start()
    {
        _bigtree = 0;

        trees = new List<GameObject>();

        trees.Add(Instantiate(Treeload, new Vector3(Random.Range(0, 100), 1, Random.Range(0, 100)),transform.rotation));
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
                trees.Add(Instantiate(Treeload, loc, transform.rotation));

            }
        }
    }
}
