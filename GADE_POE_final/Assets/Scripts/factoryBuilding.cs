using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class factoryBuilding : Building
{
    [SerializeField] protected int productionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        maxHp = hp;
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
        healthbar = GetComponentsInChildren<Image>()[1];
    }
}
