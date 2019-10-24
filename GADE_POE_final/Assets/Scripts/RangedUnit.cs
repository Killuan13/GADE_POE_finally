using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedUnit : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        maxHP = hp;
        atk = 2;
        range = 2;
        spd = 0.5f;
        team = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = mat[team - 1];
        switch (team)
        {
            case 1:
                gameObject.tag = "team 1";
                break;
            case 2:
                gameObject.tag = "team 2";
                break;
        }
    }

   
}
