using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Unit : MonoBehaviour
{
    protected Image healthBar;
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHP;
    [SerializeField] protected int atk;
    [SerializeField] protected float spd;
    [SerializeField] protected int range;
    [SerializeField] protected int team;
    [SerializeField] protected Material[] mat;

    public int Hp { get => hp; set => hp = value; }
    public int MaxHP { get => maxHP; }
    public int Atk { get => atk; }
    public float Spd { get => spd; }
    public int Range { get => range; set => range = value; }
    public int Team { get => team; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!IsInRange(GetClosestUnit()))
        {
            transform.position = Vector3.MoveTowards(transform.position, GetClosestUnit().transform.position, spd * Time.deltaTime);   
        }

        healthBar.fillAmount = (float)hp / maxHP;
        Attack();
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

        if (team == 3)
        {
            if (!IsInRange(GetClosestUnit()))
            {
                transform.position = Vector3.MoveTowards(transform.position, GetClosestUnit().transform.position, spd * Time.deltaTime);
            }

            healthBar.fillAmount = (float)hp / maxHP;
            Attack();
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    protected bool IsInRange(GameObject Enemy)
    {
        bool returnVal = false;
        if (Vector3.Distance(transform.position, Enemy.transform.position) <= range)
        {
            returnVal = true;
        }
        else returnVal = false;
        return returnVal;
    }

    protected GameObject GetClosestUnit()
    {
        GameObject unit = null;
        GameObject[] units = null;
        GameObject[] wizards = null;

        switch (team)
        {
            case 1:
                units = GameObject.FindGameObjectsWithTag("team 2");
                wizards = GameObject.FindGameObjectsWithTag("team 3");
                int tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                
                break;
            case 2:
                units = GameObject.FindGameObjectsWithTag("team 1");
                wizards = GameObject.FindGameObjectsWithTag("team 3");
                tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                break;
            case 3:
                units = GameObject.FindGameObjectsWithTag("team 1");
                wizards = GameObject.FindGameObjectsWithTag("team 2");
                tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                break;        
        }

        float distance = 9999;
        foreach (GameObject temp in units)
        {
            float tempDist = Vector3.Distance(transform.position, temp.transform.position);
            if (tempDist <= distance)
            {
                distance = tempDist;
                unit = temp;
            }
        }
        return unit;
    }

    protected void Attack()
    {
        if (IsInRange(GetClosestUnit()))
        {
            if (GetClosestUnit().GetComponent<Unit>())
            {
                GetClosestUnit().GetComponent<Unit>().hp -= atk;
            }

            if (GetClosestUnit().GetComponent<Building>())
            {
                GetClosestUnit().GetComponent<Building>().Hp -= atk;
            }
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
