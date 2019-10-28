using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    protected Image healthbar;
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int bTeam;
    [SerializeField] protected Material[] bMat;

    
    public int Hp { get => hp; set => hp = value; }
    public int MaxHp { get => maxHp; }
    public int BTeam { get => bTeam; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = (float)hp / maxHp;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    protected bool IsDead()
    {
        bool returnVal = false;
        if (hp <= 0)
        {
            returnVal = true;
            Destroy(gameObject);
        }
        return returnVal;
    }

   
}
