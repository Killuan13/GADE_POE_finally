using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateResource : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int resourceTotal = 0;
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Resource");
        foreach (GameObject o in resources)
        {
            resourceTotal += o.GetComponent<Resource>().numResource;
        }

        
    }
}
