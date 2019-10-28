﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WizardUnit : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponentsInChildren<Image>()[1];
        hp = 30;
        maxHP = hp;
        atk = 4;
        range = 2;
        spd = 1;
        GetComponent<MeshRenderer>().material = mat[team - 1];
        gameObject.tag = "team 3";
    }
}
