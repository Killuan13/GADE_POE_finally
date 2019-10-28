using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour
{
    [SerializeField] int resource;

    public int numResource { get => resource; }
    // Start is called before the first frame update
    void Start()
    {
        resource = Random.Range(0, 101);
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
        Text resourceBox1 = GameObject.Find("ResourceText").GetComponent<Text>();
        resourceBox1.text = "Resources: " + resourceTotal;
        
    }
}
