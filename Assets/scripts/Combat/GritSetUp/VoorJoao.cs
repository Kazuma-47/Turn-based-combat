using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class VoorJoao : MonoBehaviour
{
    public GameObject prefab;
    public GameObject objectToFill;
    void Start()
    {
        FillObject();
    }

    void Update()
    {

    }

    void FillObject()
    {
        var prefabWidth = prefab.GetComponent<Renderer>().bounds.size.x;
        float prefabDepth = prefab.GetComponent<Renderer>().bounds.size.z;
        float fillWidth = objectToFill.GetComponent<Renderer>().bounds.size.x;
        float fillDepth = objectToFill.GetComponent<Renderer>().bounds.size.z;

        float horizontalAmount = fillWidth / prefabDepth;
        float verticalAmount = fillDepth / prefabDepth;

        for (int i = 0; i < horizontalAmount; i++)
        {
            for (int j = 0; j < verticalAmount; j++)
            {
                GameObject obj = Instantiate(prefab, objectToFill.GetComponent<Renderer>().bounds.min + new Vector3(i * prefabWidth, 0, j * prefabDepth), Quaternion.identity);
                obj.name = $"Block {i} : {j}";
            }
        }

    }
}

