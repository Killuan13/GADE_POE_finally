using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryBuilding : Building
{
    [SerializeField] protected int productionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        bHp = 20;
        bMaxHP = bHp;
        bTeam = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = bMat[bTeam - 1];
        switch (bTeam)
        {
            case 1:
                gameObject.tag = "team 1";
                break;
            case 2:
                gameObject.tag = "team 2";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
