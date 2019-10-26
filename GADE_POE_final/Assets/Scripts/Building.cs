using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour
{
    [SerializeField] protected int bHp;
    [SerializeField] protected int bMaxHP;
    [SerializeField] protected int bTeam;
    [SerializeField] protected Material[] bMat;

    public int BHp { get => bHp; set => bHp = value; }
    public int BMaxHP { get => bMaxHP; set => bMaxHP = value; }
    public int BTeam { get => bTeam; set => bTeam = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
